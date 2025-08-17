using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identitygovernance.azuread.m.upbound.io;
#nullable enable
/// <summary>PrivilegedAccessGroupAssignmentSchedule is the Schema for the PrivilegedAccessGroupAssignmentSchedules API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivilegedAccessGroupAssignmentSchedule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivilegedAccessGroupAssignmentScheduleList";
    public const string KubeGroup = "identitygovernance.azuread.m.upbound.io";
    public const string KubePluralName = "privilegedaccessgroupassignmentschedules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1PrivilegedAccessGroupAssignmentSchedule> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Group in groups to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderGroupIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Group in groups to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderPrincipalIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a User in users to populate principalId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderPrincipalIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderPrincipalIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderPrincipalIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a User in users to populate principalId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderPrincipalIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderPrincipalIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProvider
{
    /// <summary>The type of assignment to the group. Can be either member or owner. The ID of the assignment to the group</summary>
    [JsonPropertyName("assignmentType")]
    public string? AssignmentType { get; set; }

    /// <summary>The duration that this assignment is valid for, formatted as an ISO8601 duration (e.g. P30D for 30 days, PT3H for three hours). The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>01-01T01:02:03Z). The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>The Object ID of the Azure AD group to which the principal will be assigned. The ID of the Group representing the scope of the assignment</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Reference to a Group in groups to populate groupId.</summary>
    [JsonPropertyName("groupIdRef")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderGroupIdRef? GroupIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate groupId.</summary>
    [JsonPropertyName("groupIdSelector")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderGroupIdSelector? GroupIdSelector { get; set; }

    /// <summary>The justification for this assignment. May be required by the role policy. The justification for the assignment</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>Is this assigment permanently valid. Is the assignment permanent</summary>
    [JsonPropertyName("permanentAssignment")]
    public bool? PermanentAssignment { get; set; }

    /// <summary>The Object ID of the principal to be assigned to the above group. Can be either a user or a group. The ID of the Principal assigned to the schedule</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Reference to a User in users to populate principalId.</summary>
    [JsonPropertyName("principalIdRef")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderPrincipalIdRef? PrincipalIdRef { get; set; }

    /// <summary>Selector for a User in users to populate principalId.</summary>
    [JsonPropertyName("principalIdSelector")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProviderPrincipalIdSelector? PrincipalIdSelector { get; set; }

    /// <summary>01-01T01:02:03Z). If not provided, the assignment is immediately valid. The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The ticket number in the ticket system approving this assignment. May be required by the role policy. The ticket number authorising the assignment</summary>
    [JsonPropertyName("ticketNumber")]
    public string? TicketNumber { get; set; }

    /// <summary>The ticket system containing the ticket number approving this assignment. May be required by the role policy. The ticket system authorising the assignment</summary>
    [JsonPropertyName("ticketSystem")]
    public string? TicketSystem { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Group in groups to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderGroupIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Group in groups to populate groupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderGroupIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderPrincipalIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a User in users to populate principalId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderPrincipalIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderPrincipalIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderPrincipalIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a User in users to populate principalId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderPrincipalIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderPrincipalIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProvider
{
    /// <summary>The type of assignment to the group. Can be either member or owner. The ID of the assignment to the group</summary>
    [JsonPropertyName("assignmentType")]
    public string? AssignmentType { get; set; }

    /// <summary>The duration that this assignment is valid for, formatted as an ISO8601 duration (e.g. P30D for 30 days, PT3H for three hours). The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>01-01T01:02:03Z). The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>The Object ID of the Azure AD group to which the principal will be assigned. The ID of the Group representing the scope of the assignment</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Reference to a Group in groups to populate groupId.</summary>
    [JsonPropertyName("groupIdRef")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderGroupIdRef? GroupIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate groupId.</summary>
    [JsonPropertyName("groupIdSelector")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderGroupIdSelector? GroupIdSelector { get; set; }

    /// <summary>The justification for this assignment. May be required by the role policy. The justification for the assignment</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>Is this assigment permanently valid. Is the assignment permanent</summary>
    [JsonPropertyName("permanentAssignment")]
    public bool? PermanentAssignment { get; set; }

    /// <summary>The Object ID of the principal to be assigned to the above group. Can be either a user or a group. The ID of the Principal assigned to the schedule</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Reference to a User in users to populate principalId.</summary>
    [JsonPropertyName("principalIdRef")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderPrincipalIdRef? PrincipalIdRef { get; set; }

    /// <summary>Selector for a User in users to populate principalId.</summary>
    [JsonPropertyName("principalIdSelector")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProviderPrincipalIdSelector? PrincipalIdSelector { get; set; }

    /// <summary>01-01T01:02:03Z). If not provided, the assignment is immediately valid. The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The ticket number in the ticket system approving this assignment. May be required by the role policy. The ticket number authorising the assignment</summary>
    [JsonPropertyName("ticketNumber")]
    public string? TicketNumber { get; set; }

    /// <summary>The ticket system containing the ticket number approving this assignment. May be required by the role policy. The ticket system authorising the assignment</summary>
    [JsonPropertyName("ticketSystem")]
    public string? TicketSystem { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PrivilegedAccessGroupAssignmentScheduleSpec defines the desired state of PrivilegedAccessGroupAssignmentSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleStatusAtProvider
{
    /// <summary>The type of assignment to the group. Can be either member or owner. The ID of the assignment to the group</summary>
    [JsonPropertyName("assignmentType")]
    public string? AssignmentType { get; set; }

    /// <summary>The duration that this assignment is valid for, formatted as an ISO8601 duration (e.g. P30D for 30 days, PT3H for three hours). The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>01-01T01:02:03Z). The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>The Object ID of the Azure AD group to which the principal will be assigned. The ID of the Group representing the scope of the assignment</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>(String) The ID of this request.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The justification for this assignment. May be required by the role policy. The justification for the assignment</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>Is this assigment permanently valid. Is the assignment permanent</summary>
    [JsonPropertyName("permanentAssignment")]
    public bool? PermanentAssignment { get; set; }

    /// <summary>The Object ID of the principal to be assigned to the above group. Can be either a user or a group. The ID of the Principal assigned to the schedule</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>01-01T01:02:03Z). If not provided, the assignment is immediately valid. The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>(String) The provisioning status of this request. The status of the schedule</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ticket number in the ticket system approving this assignment. May be required by the role policy. The ticket number authorising the assignment</summary>
    [JsonPropertyName("ticketNumber")]
    public string? TicketNumber { get; set; }

    /// <summary>The ticket system containing the ticket number approving this assignment. May be required by the role policy. The ticket system authorising the assignment</summary>
    [JsonPropertyName("ticketSystem")]
    public string? TicketSystem { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleStatusConditions
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
#nullable disable

#nullable enable
/// <summary>PrivilegedAccessGroupAssignmentScheduleStatus defines the observed state of PrivilegedAccessGroupAssignmentSchedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessGroupAssignmentScheduleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivilegedAccessGroupAssignmentScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PrivilegedAccessGroupAssignmentSchedule is the Schema for the PrivilegedAccessGroupAssignmentSchedules API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivilegedAccessGroupAssignmentSchedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivilegedAccessGroupAssignmentScheduleSpec>, IStatus<V1beta1PrivilegedAccessGroupAssignmentScheduleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivilegedAccessGroupAssignmentSchedule";
    public const string KubeGroup = "identitygovernance.azuread.m.upbound.io";
    public const string KubePluralName = "privilegedaccessgroupassignmentschedules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivilegedAccessGroupAssignmentScheduleSpec defines the desired state of PrivilegedAccessGroupAssignmentSchedule</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleSpec Spec { get; set; }

    /// <summary>PrivilegedAccessGroupAssignmentScheduleStatus defines the observed state of PrivilegedAccessGroupAssignmentSchedule.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivilegedAccessGroupAssignmentScheduleStatus? Status { get; set; }
}
#nullable disable
