using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.orgpolicy.cnrm.cloud.google.com;
/// <summary>OrgPolicyPolicy is the Schema for the OrgPolicyPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrgPolicyPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1OrgPolicyPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrgPolicyPolicyList";
    public const string KubeGroup = "orgpolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "orgpolicypolicies";
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
    public IList<V1alpha1OrgPolicyPolicy> Items { get; set; }
}

/// <summary>A condition which determines whether this rule is used in the evaluation of the policy. When set, the `expression` field in the `Expr' must include from 1 to 10 subexpressions, joined by the "||" or "&amp;&amp;" operators. Each subexpression must be of the form "resource.matchTag('&lt;ORG_ID&gt;/tag_key_short_name, 'tag_value_short_name')". or "resource.matchTagId('tagKeys/key_id', 'tagValues/value_id')". where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: "resource.matchTag('123456789/environment, 'prod')". or "resource.matchTagId('tagKeys/123', 'tagValues/456')".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecDryRunSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>List of values to be used for this policy rule. This field can be set only in policies for list constraints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecDryRunSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecDryRunSpecRules
{
    /// <summary>Setting this to true means that all values are allowed. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public bool? AllowAll { get; set; }

    /// <summary>A condition which determines whether this rule is used in the evaluation of the policy. When set, the `expression` field in the `Expr' must include from 1 to 10 subexpressions, joined by the "||" or "&amp;&amp;" operators. Each subexpression must be of the form "resource.matchTag('&lt;ORG_ID&gt;/tag_key_short_name, 'tag_value_short_name')". or "resource.matchTagId('tagKeys/key_id', 'tagValues/value_id')". where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: "resource.matchTag('123456789/environment, 'prod')". or "resource.matchTagId('tagKeys/123', 'tagValues/456')".</summary>
    [JsonPropertyName("condition")]
    public V1alpha1OrgPolicyPolicySpecDryRunSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to true means that all values are denied. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public bool? DenyAll { get; set; }

    /// <summary>If `true`, then the policy is enforced. If `false`, then any configuration is acceptable. This field can be set only in policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>List of values to be used for this policy rule. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("values")]
    public V1alpha1OrgPolicyPolicySpecDryRunSpecRulesValues? Values { get; set; }
}

/// <summary>Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it's enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecDryRunSpec
{
    /// <summary>An opaque tag indicating the current version of the policySpec, used for  concurrency control.   This field is ignored if used in a `CreatePolicy` request.   When the policy is returned from either a `GetPolicy` or a  `ListPolicies` request, this `etag` indicates the version of the  current policySpec to use when executing a read-modify-write loop.   When the policy is returned from a `GetEffectivePolicy` request, the  `etag` will be unset.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Determines the inheritance behavior for this policy.   If `inherit_from_parent` is true, policy rules set higher up in the  hierarchy (up to the closest root) are inherited and present in the  effective policy. If it is false, then no rules are inherited, and this  policy becomes the new root for evaluation.  This field can be set only for policies which configure list constraints.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, `rules` must be empty and `inherit_from_parent` must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>In policies for boolean constraints, the following requirements apply:     - There must be one and only one policy rule where condition is unset.    - Boolean policy rules with conditions must set `enforced` to the      opposite of the policy rule without a condition.    - During policy evaluation, policy rules with conditions that are      true for a target resource take precedence.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1OrgPolicyPolicySpecDryRunSpecRules>? Rules { get; set; }
}

/// <summary>Immutable. The Folder that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecFolderRef
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
public partial class V1alpha1OrgPolicyPolicySpecOrganizationRef
{
    /// <summary>The 'name' field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string External { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecProjectRef
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

/// <summary>A condition which determines whether this rule is used in the evaluation of the policy. When set, the `expression` field in the `Expr' must include from 1 to 10 subexpressions, joined by the "||" or "&amp;&amp;" operators. Each subexpression must be of the form "resource.matchTag('&lt;ORG_ID&gt;/tag_key_short_name, 'tag_value_short_name')". or "resource.matchTagId('tagKeys/key_id', 'tagValues/value_id')". where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: "resource.matchTag('123456789/environment, 'prod')". or "resource.matchTagId('tagKeys/123', 'tagValues/456')".</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecSpecRulesCondition
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>List of values to be used for this policy rule. This field can be set only in policies for list constraints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecSpecRulesValues
{
    /// <summary>List of values allowed at this resource.</summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>List of values denied at this resource.</summary>
    [JsonPropertyName("deniedValues")]
    public IList<string>? DeniedValues { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecSpecRules
{
    /// <summary>Setting this to true means that all values are allowed. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("allowAll")]
    public bool? AllowAll { get; set; }

    /// <summary>A condition which determines whether this rule is used in the evaluation of the policy. When set, the `expression` field in the `Expr' must include from 1 to 10 subexpressions, joined by the "||" or "&amp;&amp;" operators. Each subexpression must be of the form "resource.matchTag('&lt;ORG_ID&gt;/tag_key_short_name, 'tag_value_short_name')". or "resource.matchTagId('tagKeys/key_id', 'tagValues/value_id')". where key_name and value_name are the resource names for Label Keys and Values. These names are available from the Tag Manager Service. An example expression is: "resource.matchTag('123456789/environment, 'prod')". or "resource.matchTagId('tagKeys/123', 'tagValues/456')".</summary>
    [JsonPropertyName("condition")]
    public V1alpha1OrgPolicyPolicySpecSpecRulesCondition? Condition { get; set; }

    /// <summary>Setting this to true means that all values are denied. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("denyAll")]
    public bool? DenyAll { get; set; }

    /// <summary>If `true`, then the policy is enforced. If `false`, then any configuration is acceptable. This field can be set only in policies for boolean constraints.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>List of values to be used for this policy rule. This field can be set only in policies for list constraints.</summary>
    [JsonPropertyName("values")]
    public V1alpha1OrgPolicyPolicySpecSpecRulesValues? Values { get; set; }
}

/// <summary>Basic information about the Organization Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpecSpec
{
    /// <summary>An opaque tag indicating the current version of the policySpec, used for  concurrency control.   This field is ignored if used in a `CreatePolicy` request.   When the policy is returned from either a `GetPolicy` or a  `ListPolicies` request, this `etag` indicates the version of the  current policySpec to use when executing a read-modify-write loop.   When the policy is returned from a `GetEffectivePolicy` request, the  `etag` will be unset.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Determines the inheritance behavior for this policy.   If `inherit_from_parent` is true, policy rules set higher up in the  hierarchy (up to the closest root) are inherited and present in the  effective policy. If it is false, then no rules are inherited, and this  policy becomes the new root for evaluation.  This field can be set only for policies which configure list constraints.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, `rules` must be empty and `inherit_from_parent` must be set to false.</summary>
    [JsonPropertyName("reset")]
    public bool? Reset { get; set; }

    /// <summary>In policies for boolean constraints, the following requirements apply:     - There must be one and only one policy rule where condition is unset.    - Boolean policy rules with conditions must set `enforced` to the      opposite of the policy rule without a condition.    - During policy evaluation, policy rules with conditions that are      true for a target resource take precedence.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1OrgPolicyPolicySpecSpecRules>? Rules { get; set; }
}

/// <summary>OrgPolicyPolicySpec defines the desired state of OrgPolicyPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicySpec
{
    /// <summary>Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it's enforced.</summary>
    [JsonPropertyName("dryRunSpec")]
    public V1alpha1OrgPolicyPolicySpecDryRunSpec? DryRunSpec { get; set; }

    /// <summary>Optional. An opaque tag indicating the current state of the policy, used for concurrency control. This 'etag' is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Immutable. The Folder that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
    [JsonPropertyName("folderRef")]
    public V1alpha1OrgPolicyPolicySpecFolderRef? FolderRef { get; set; }

    /// <summary>Immutable. The Organization that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
    [JsonPropertyName("organizationRef")]
    public V1alpha1OrgPolicyPolicySpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to. One and only one of 'projectRef', 'folderRef', or 'organizationRef' must be set.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1OrgPolicyPolicySpecProjectRef? ProjectRef { get; set; }

    /// <summary>The OrgPolicyPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Basic information about the Organization Policy.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1OrgPolicyPolicySpecSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicyStatusConditions
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

/// <summary>Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it's enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicyStatusObservedStateDryRunSpec
{
    /// <summary>Output only. The time stamp this was previously updated. This represents the last time a call to `CreatePolicy` or `UpdatePolicy` was made for that policy.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>Basic information about the Organization Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicyStatusObservedStateSpec
{
    /// <summary>Output only. The time stamp this was previously updated. This represents the last time a call to `CreatePolicy` or `UpdatePolicy` was made for that policy.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicyStatusObservedState
{
    /// <summary>Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing and future resources if it's enforced.</summary>
    [JsonPropertyName("dryRunSpec")]
    public V1alpha1OrgPolicyPolicyStatusObservedStateDryRunSpec? DryRunSpec { get; set; }

    /// <summary>Basic information about the Organization Policy.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1OrgPolicyPolicyStatusObservedStateSpec? Spec { get; set; }
}

/// <summary>OrgPolicyPolicyStatus defines the config connector machine state of OrgPolicyPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OrgPolicyPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OrgPolicyPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the OrgPolicyPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1OrgPolicyPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>OrgPolicyPolicy is the Schema for the OrgPolicyPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OrgPolicyPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OrgPolicyPolicySpec>, IStatus<V1alpha1OrgPolicyPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OrgPolicyPolicy";
    public const string KubeGroup = "orgpolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "orgpolicypolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrgPolicyPolicySpec defines the desired state of OrgPolicyPolicy</summary>
    [JsonPropertyName("spec")]
    public V1alpha1OrgPolicyPolicySpec Spec { get; set; }

    /// <summary>OrgPolicyPolicyStatus defines the config connector machine state of OrgPolicyPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1OrgPolicyPolicyStatus? Status { get; set; }
}