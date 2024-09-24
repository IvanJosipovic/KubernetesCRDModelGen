using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>A expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Conflicts with schedule[0].expiration[0].duration_hours,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Active Role Assignment to be created. The duration of the assignment in days.</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Active Role Assignment to be created. The duration of the assignment in hours.</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date time of the role assignment. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].duration_hours Changing this forces a new Pim Active Role Assignment to be created. The end date time of the assignment.</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>A schedule block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The schedule details of this role assignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderSchedule
{
    /// <summary>A expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date time of the role assignment. Changing this forces a new Pim Active Role Assignment to be created. The start date time.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary>A ticket block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The ticket details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderTicket
{
    /// <summary>The ticket number. The ticket number.</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>The ticket system. The ticket system.</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProvider
{
    /// <summary>The justification of the role assignment. Changing this forces a new Pim Active Role Assignment to be created. The justification of the role assignment.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>The principal id. Changing this forces a new Pim Active Role Assignment to be created. The principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The role definition id. Changing this forces a new Pim Active Role Assignment to be created. The role definition id.</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The schedule details of this role assignment.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>The scope. Changing this forces a new Pim Active Role Assignment to be created. The scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The ticket details.</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderTicket? Ticket { get; set; }
}

/// <summary>A expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Conflicts with schedule[0].expiration[0].duration_hours,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Active Role Assignment to be created. The duration of the assignment in days.</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Active Role Assignment to be created. The duration of the assignment in hours.</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date time of the role assignment. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].duration_hours Changing this forces a new Pim Active Role Assignment to be created. The end date time of the assignment.</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>A schedule block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The schedule details of this role assignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderSchedule
{
    /// <summary>A expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date time of the role assignment. Changing this forces a new Pim Active Role Assignment to be created. The start date time.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary>A ticket block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The ticket details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderTicket
{
    /// <summary>The ticket number. The ticket number.</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>The ticket system. The ticket system.</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProvider
{
    /// <summary>The justification of the role assignment. Changing this forces a new Pim Active Role Assignment to be created. The justification of the role assignment.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>The principal id. Changing this forces a new Pim Active Role Assignment to be created. The principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The role definition id. Changing this forces a new Pim Active Role Assignment to be created. The role definition id.</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The schedule details of this role assignment.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>The scope. Changing this forces a new Pim Active Role Assignment to be created. The scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The ticket details.</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderTicket? Ticket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimActiveRoleAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PimActiveRoleAssignmentSpec defines the desired state of PimActiveRoleAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecDeletionPolicyEnum>))]
    public V1beta1PimActiveRoleAssignmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PimActiveRoleAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PimActiveRoleAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PimActiveRoleAssignmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PimActiveRoleAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PimActiveRoleAssignmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PimActiveRoleAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusAtProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Conflicts with schedule[0].expiration[0].duration_hours,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Active Role Assignment to be created. The duration of the assignment in days.</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].end_date_time Changing this forces a new Pim Active Role Assignment to be created. The duration of the assignment in hours.</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date time of the role assignment. Conflicts with schedule[0].expiration[0].duration_days,schedule[0].expiration[0].duration_hours Changing this forces a new Pim Active Role Assignment to be created. The end date time of the assignment.</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>A schedule block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The schedule details of this role assignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusAtProviderSchedule
{
    /// <summary>A expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimActiveRoleAssignmentStatusAtProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date time of the role assignment. Changing this forces a new Pim Active Role Assignment to be created. The start date time.</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

/// <summary>A ticket block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The ticket details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusAtProviderTicket
{
    /// <summary>The ticket number. The ticket number.</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>The ticket system. The ticket system.</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusAtProvider
{
    /// <summary>The ID of the Pim Active Role Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The justification of the role assignment. Changing this forces a new Pim Active Role Assignment to be created. The justification of the role assignment.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>The principal id. Changing this forces a new Pim Active Role Assignment to be created. The principal id.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The type of principal. The type of principal.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>The role definition id. Changing this forces a new Pim Active Role Assignment to be created. The role definition id.</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The schedule details of this role assignment.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimActiveRoleAssignmentStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>The scope. Changing this forces a new Pim Active Role Assignment to be created. The scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new Pim Active Role Assignment to be created. The ticket details.</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimActiveRoleAssignmentStatusAtProviderTicket? Ticket { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusConditions
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

/// <summary>PimActiveRoleAssignmentStatus defines the observed state of PimActiveRoleAssignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PimActiveRoleAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PimActiveRoleAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PimActiveRoleAssignment is the Schema for the PimActiveRoleAssignments API. Manages a Pim Active Role Assignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PimActiveRoleAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PimActiveRoleAssignmentSpec>, IStatus<V1beta1PimActiveRoleAssignmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PimActiveRoleAssignment";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "pimactiveroleassignments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PimActiveRoleAssignmentSpec defines the desired state of PimActiveRoleAssignment</summary>
    [JsonPropertyName("spec")]
    public V1beta1PimActiveRoleAssignmentSpec Spec { get; set; }

    /// <summary>PimActiveRoleAssignmentStatus defines the observed state of PimActiveRoleAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1PimActiveRoleAssignmentStatus? Status { get; set; }
}