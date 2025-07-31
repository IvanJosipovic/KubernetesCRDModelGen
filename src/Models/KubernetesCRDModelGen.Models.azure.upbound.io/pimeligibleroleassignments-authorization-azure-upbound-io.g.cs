using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.upbound.io;
/// <summary>An expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Changing this forces a new resource to be created. The duration of the eligible role assignment in days</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Changing this forces a new resource to be created. The duration of the eligible role assignment in hours</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date/time of the role assignment. Changing this forces a new resource to be created. The end date/time of the eligible role assignment</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>A schedule block as defined below. Changing this forces a new resource to be created. The schedule details for this eligible role assignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderSchedule
{
    /// <summary>An expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date/time of the role assignment. Changing this forces a new resource to be created. The start date/time</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>A ticket block as defined below. Changing this forces a new resource to be created. Ticket details relating to the eligible assignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecForProviderTicket
{
    /// <summary>User-supplied ticket number to be included with the request. Changing this forces a new resource to be created. User-supplied ticket number to be included with the request</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>User-supplied ticket system name to be included with the request. Changing this forces a new resource to be created. User-supplied ticket system name to be included with the request</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecForProvider
{
    /// <summary>The condition that limits the resources that the role can be assigned to. See the official conditions documentation for details. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>The version of the condition. Supported values include 2.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conditionVersion")]
    public string? ConditionVersion { get; set; }

    /// <summary>The justification of the role assignment. Changing this forces a new resource to be created. The justification for this eligible role assignment</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>Object ID of the principal for this eligible role assignment. Changing this forces a new resource to be created. Object ID of the principal for this eligible role assignment</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The role definition ID for this eligible role assignment. Changing this forces a new resource to be created. Role definition ID for this eligible role assignment</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new resource to be created. The schedule details for this eligible role assignment</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>The scope for this eligible role assignment, should be a valid resource ID. Changing this forces a new resource to be created. Scope for this eligible role assignment, should be a valid resource ID</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new resource to be created. Ticket details relating to the eligible assignment</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimEligibleRoleAssignmentSpecForProviderTicket? Ticket { get; set; }
}

/// <summary>An expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Changing this forces a new resource to be created. The duration of the eligible role assignment in days</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Changing this forces a new resource to be created. The duration of the eligible role assignment in hours</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date/time of the role assignment. Changing this forces a new resource to be created. The end date/time of the eligible role assignment</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>A schedule block as defined below. Changing this forces a new resource to be created. The schedule details for this eligible role assignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderSchedule
{
    /// <summary>An expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date/time of the role assignment. Changing this forces a new resource to be created. The start date/time</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>A ticket block as defined below. Changing this forces a new resource to be created. Ticket details relating to the eligible assignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecInitProviderTicket
{
    /// <summary>User-supplied ticket number to be included with the request. Changing this forces a new resource to be created. User-supplied ticket number to be included with the request</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>User-supplied ticket system name to be included with the request. Changing this forces a new resource to be created. User-supplied ticket system name to be included with the request</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecInitProvider
{
    /// <summary>The condition that limits the resources that the role can be assigned to. See the official conditions documentation for details. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>The version of the condition. Supported values include 2.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conditionVersion")]
    public string? ConditionVersion { get; set; }

    /// <summary>The justification of the role assignment. Changing this forces a new resource to be created. The justification for this eligible role assignment</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>Object ID of the principal for this eligible role assignment. Changing this forces a new resource to be created. Object ID of the principal for this eligible role assignment</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The role definition ID for this eligible role assignment. Changing this forces a new resource to be created. Role definition ID for this eligible role assignment</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new resource to be created. The schedule details for this eligible role assignment</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>The scope for this eligible role assignment, should be a valid resource ID. Changing this forces a new resource to be created. Scope for this eligible role assignment, should be a valid resource ID</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new resource to be created. Ticket details relating to the eligible assignment</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProviderTicket? Ticket { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimEligibleRoleAssignmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PimEligibleRoleAssignmentSpec defines the desired state of PimEligibleRoleAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PimEligibleRoleAssignmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PimEligibleRoleAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

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

/// <summary>An expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentStatusAtProviderScheduleExpiration
{
    /// <summary>The duration of the role assignment in days. Changing this forces a new resource to be created. The duration of the eligible role assignment in days</summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>The duration of the role assignment in hours. Changing this forces a new resource to be created. The duration of the eligible role assignment in hours</summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>The end date/time of the role assignment. Changing this forces a new resource to be created. The end date/time of the eligible role assignment</summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>A schedule block as defined below. Changing this forces a new resource to be created. The schedule details for this eligible role assignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentStatusAtProviderSchedule
{
    /// <summary>An expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimEligibleRoleAssignmentStatusAtProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>The start date/time of the role assignment. Changing this forces a new resource to be created. The start date/time</summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

/// <summary>A ticket block as defined below. Changing this forces a new resource to be created. Ticket details relating to the eligible assignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentStatusAtProviderTicket
{
    /// <summary>User-supplied ticket number to be included with the request. Changing this forces a new resource to be created. User-supplied ticket number to be included with the request</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>User-supplied ticket system name to be included with the request. Changing this forces a new resource to be created. User-supplied ticket system name to be included with the request</summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimEligibleRoleAssignmentStatusAtProvider
{
    /// <summary>The condition that limits the resources that the role can be assigned to. See the official conditions documentation for details. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>The version of the condition. Supported values include 2.0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conditionVersion")]
    public string? ConditionVersion { get; set; }

    /// <summary>The ID of the PIM Eligible Role Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The justification of the role assignment. Changing this forces a new resource to be created. The justification for this eligible role assignment</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>Object ID of the principal for this eligible role assignment. Changing this forces a new resource to be created. Object ID of the principal for this eligible role assignment</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Type of principal to which the role will be assigned. Type of principal to which the role will be assigned</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>The role definition ID for this eligible role assignment. Changing this forces a new resource to be created. Role definition ID for this eligible role assignment</summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>A schedule block as defined below. Changing this forces a new resource to be created. The schedule details for this eligible role assignment</summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimEligibleRoleAssignmentStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>The scope for this eligible role assignment, should be a valid resource ID. Changing this forces a new resource to be created. Scope for this eligible role assignment, should be a valid resource ID</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>A ticket block as defined below. Changing this forces a new resource to be created. Ticket details relating to the eligible assignment</summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimEligibleRoleAssignmentStatusAtProviderTicket? Ticket { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>PimEligibleRoleAssignmentStatus defines the observed state of PimEligibleRoleAssignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>PimEligibleRoleAssignment is the Schema for the PimEligibleRoleAssignments API. Manages a PIM Eligible Role Assignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>PimEligibleRoleAssignment is the Schema for the PimEligibleRoleAssignments API. Manages a PIM Eligible Role Assignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PimEligibleRoleAssignmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PimEligibleRoleAssignment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PimEligibleRoleAssignmentList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1PimEligibleRoleAssignment> Items { get; set; }
}