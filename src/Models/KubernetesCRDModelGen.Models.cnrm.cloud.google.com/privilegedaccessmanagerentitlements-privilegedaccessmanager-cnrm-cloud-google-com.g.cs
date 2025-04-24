using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.privilegedaccessmanager.cnrm.cloud.google.com;
/// <summary>Optional. Additional email addresses to be notified based on actions taken.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecAdditionalNotificationTargets
{
    /// <summary>Optional. Additional email addresses to be notified when a principal (requester) is granted access.</summary>
    [JsonPropertyName("adminEmailRecipients")]
    public IList<string>? AdminEmailRecipients { get; set; }

    /// <summary>Optional. Additional email address to be notified about an eligible entitlement.</summary>
    [JsonPropertyName("requesterEmailRecipients")]
    public IList<string>? RequesterEmailRecipients { get; set; }
}

/// <summary>AccessControlEntry is used to control who can do some operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecApprovalWorkflowManualApprovalsStepsApprovers
{
    /// <summary>Optional. Users who are allowed for the operation. Each entry should be a valid v1 IAM principal identifier. The format for these is documented at: https://cloud.google.com/iam/docs/principal-identifiers#v1</summary>
    [JsonPropertyName("principals")]
    public IList<string> Principals { get; set; }
}

/// <summary>Step represents a logical step in a manual approval workflow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecApprovalWorkflowManualApprovalsSteps
{
    /// <summary>Required. How many users from the above list need to approve. If there aren't enough distinct users in the list, then the workflow indefinitely blocks. Should always be greater than 0. 1 is the only supported value.</summary>
    [JsonPropertyName("approvalsNeeded")]
    public int ApprovalsNeeded { get; set; }

    /// <summary>Optional. Additional email addresses to be notified when a grant is pending approval.</summary>
    [JsonPropertyName("approverEmailRecipients")]
    public IList<string>? ApproverEmailRecipients { get; set; }

    /// <summary>Optional. The potential set of approvers in this step. This list must contain at most one entry.</summary>
    [JsonPropertyName("approvers")]
    public IList<V1beta1PrivilegedAccessManagerEntitlementSpecApprovalWorkflowManualApprovalsStepsApprovers>? Approvers { get; set; }
}

/// <summary>An approval workflow where users designated as approvers review and act on the grants.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecApprovalWorkflowManualApprovals
{
    /// <summary>Optional. Whether the approvers need to provide a justification for their actions.</summary>
    [JsonPropertyName("requireApproverJustification")]
    public bool? RequireApproverJustification { get; set; }

    /// <summary>Optional. List of approval steps in this workflow. These steps are followed in the specified order sequentially. Only 1 step is supported.</summary>
    [JsonPropertyName("steps")]
    public IList<V1beta1PrivilegedAccessManagerEntitlementSpecApprovalWorkflowManualApprovalsSteps>? Steps { get; set; }
}

/// <summary>Optional. The approvals needed before access are granted to a requester. No approvals are needed if this field is null.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecApprovalWorkflow
{
    /// <summary>An approval workflow where users designated as approvers review and act on the grants.</summary>
    [JsonPropertyName("manualApprovals")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecApprovalWorkflowManualApprovals ManualApprovals { get; set; }
}

/// <summary>AccessControlEntry is used to control who can do some operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecEligibleUsers
{
    /// <summary>Optional. Users who are allowed for the operation. Each entry should be a valid v1 IAM principal identifier. The format for these is documented at: https://cloud.google.com/iam/docs/principal-identifiers#v1</summary>
    [JsonPropertyName("principals")]
    public IList<string> Principals { get; set; }
}

/// <summary>Immutable. The Folder that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecFolderRef
{
    /// <summary>The 'name' field of a folder, when not managed by Config Connector. This field must be set when 'name' field is not set.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The 'name' field of a 'Folder' resource. This field must be set when 'external' field is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The 'namespace' field of a 'Folder' resource. If unset, the namespace is defaulted to the namespace of the referencer resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Organization that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecOrganizationRef
{
    /// <summary>The 'name' field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}

/// <summary>RoleBinding represents IAM role bindings that are created after a successful grant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecPrivilegedAccessGcpIAMAccessRoleBindings
{
    /// <summary>Optional. The expression field of the IAM condition to be associated with the role. If specified, a user with an active grant for this entitlement is able to access the resource only if this condition evaluates to true for their request.  This field uses the same CEL format as IAM and supports all attributes that IAM supports, except tags. More details can be found at https://cloud.google.com/iam/docs/conditions-overview#attributes.</summary>
    [JsonPropertyName("conditionExpression")]
    public string? ConditionExpression { get; set; }

    /// <summary>Required. IAM role to be granted. More details can be found at https://cloud.google.com/iam/docs/roles-overview.</summary>
    [JsonPropertyName("role")]
    public string Role { get; set; }
}

/// <summary>Access to a Google Cloud resource through IAM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecPrivilegedAccessGcpIAMAccess
{
    /// <summary>Required. Role bindings that are created on successful grant.</summary>
    [JsonPropertyName("roleBindings")]
    public IList<V1beta1PrivilegedAccessManagerEntitlementSpecPrivilegedAccessGcpIAMAccessRoleBindings> RoleBindings { get; set; }
}

/// <summary>The access granted to a requester on successful approval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecPrivilegedAccess
{
    /// <summary>Access to a Google Cloud resource through IAM.</summary>
    [JsonPropertyName("gcpIAMAccess")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecPrivilegedAccessGcpIAMAccess GcpIAMAccess { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The manner in which the requester should provide a justification for requesting access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpecRequesterJustificationConfig
{
    /// <summary>NotMandatory justification type means the justification isn't required and can be provided in any of the supported formats. The user must explicitly opt out using this field if a justification from the requester isn't mandatory. The only accepted value is `{}` (empty struct). Either 'notMandatory' or 'unstructured' field must be set.</summary>
    [JsonPropertyName("notMandatory")]
    public JsonNode? NotMandatory { get; set; }

    /// <summary>Unstructured justification type means the justification is in the format of a string. If this is set, the server allows the requester to provide a justification but doesn't validate it. The only accepted value is `{}` (empty struct). Either 'notMandatory' or 'unstructured' field must be set.</summary>
    [JsonPropertyName("unstructured")]
    public JsonNode? Unstructured { get; set; }
}

/// <summary>PrivilegedAccessManagerEntitlementSpec defines the desired state of PrivilegedAccessManagerEntitlement.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementSpec
{
    /// <summary>Optional. Additional email addresses to be notified based on actions taken.</summary>
    [JsonPropertyName("additionalNotificationTargets")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecAdditionalNotificationTargets? AdditionalNotificationTargets { get; set; }

    /// <summary>Optional. The approvals needed before access are granted to a requester. No approvals are needed if this field is null.</summary>
    [JsonPropertyName("approvalWorkflow")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecApprovalWorkflow? ApprovalWorkflow { get; set; }

    /// <summary>Who can create grants using this entitlement. This list should contain at most one entry.</summary>
    [JsonPropertyName("eligibleUsers")]
    public IList<V1beta1PrivilegedAccessManagerEntitlementSpecEligibleUsers> EligibleUsers { get; set; }

    /// <summary>Immutable. The Folder that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecFolderRef? FolderRef { get; set; }

    /// <summary>Immutable. Location of the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Required. The maximum amount of time that access is granted for a request. A requester can ask for a duration less than this, but never more.</summary>
    [JsonPropertyName("maxRequestDuration")]
    public string MaxRequestDuration { get; set; }

    /// <summary>Immutable. The Organization that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>The access granted to a requester on successful approval.</summary>
    [JsonPropertyName("privilegedAccess")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecPrivilegedAccess PrivilegedAccess { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Required. The manner in which the requester should provide a justification for requesting access.</summary>
    [JsonPropertyName("requesterJustificationConfig")]
    public V1beta1PrivilegedAccessManagerEntitlementSpecRequesterJustificationConfig RequesterJustificationConfig { get; set; }

    /// <summary>Immutable. The PrivilegedAccessManagerEntitlement name. If not given, the 'metadata.name' will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementStatusObservedState
{
    /// <summary>Output only. Create time stamp.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>An 'etag' is used for optimistic concurrency control as a way to prevent simultaneous updates to the same entitlement. An 'etag' is returned in the response to 'GetEntitlement' and the caller should put the 'etag' in the request to 'UpdateEntitlement' so that their change is applied on the same version. If this field is omitted or if there is a mismatch while updating an entitlement, then the server rejects the request.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Current state of this entitlement.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Update time stamp.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>PrivilegedAccessManagerEntitlementStatus defines the config connector machine state of PrivilegedAccessManagerEntitlement.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivilegedAccessManagerEntitlementStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivilegedAccessManagerEntitlementStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the PrivilegedAccessManagerEntitlement resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to 'metadata.generation', then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1PrivilegedAccessManagerEntitlementStatusObservedState? ObservedState { get; set; }
}

/// <summary>PrivilegedAccessManagerEntitlement is the Schema for the PrivilegedAccessManagerEntitlement API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivilegedAccessManagerEntitlement : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivilegedAccessManagerEntitlementSpec>, IStatus<V1beta1PrivilegedAccessManagerEntitlementStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivilegedAccessManagerEntitlement";
    public const string KubeGroup = "privilegedaccessmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "privilegedaccessmanagerentitlements";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivilegedAccessManagerEntitlementSpec defines the desired state of PrivilegedAccessManagerEntitlement.</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrivilegedAccessManagerEntitlementSpec? Spec { get; set; }

    /// <summary>PrivilegedAccessManagerEntitlementStatus defines the config connector machine state of PrivilegedAccessManagerEntitlement.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivilegedAccessManagerEntitlementStatus? Status { get; set; }
}

/// <summary>PrivilegedAccessManagerEntitlement is the Schema for the PrivilegedAccessManagerEntitlement API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivilegedAccessManagerEntitlementList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivilegedAccessManagerEntitlement>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivilegedAccessManagerEntitlementList";
    public const string KubeGroup = "privilegedaccessmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "privilegedaccessmanagerentitlements";
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
    public IList<V1beta1PrivilegedAccessManagerEntitlement> Items { get; set; }
}