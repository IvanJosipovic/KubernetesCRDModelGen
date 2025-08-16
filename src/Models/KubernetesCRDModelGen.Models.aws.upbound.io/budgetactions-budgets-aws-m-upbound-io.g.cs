using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.budgets.aws.m.upbound.io;
/// <summary>BudgetAction is the Schema for the BudgetActions API. Provides a budget action resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BudgetActionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BudgetAction>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetActionList";
    public const string KubeGroup = "budgets.aws.m.upbound.io";
    public const string KubePluralName = "budgetactions";
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
    public IList<V1beta1BudgetAction> Items { get; set; }
}

/// <summary>The trigger threshold of the action. See Action Threshold.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderActionThreshold
{
    /// <summary>The type of threshold for a notification. Valid values are PERCENTAGE or ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("actionThresholdType")]
    public string? ActionThresholdType { get; set; }

    /// <summary>The threshold of a notification.</summary>
    [JsonPropertyName("actionThresholdValue")]
    public double? ActionThresholdValue { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderBudgetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Budget in budgets to populate budgetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderBudgetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetActionSpecForProviderBudgetNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderBudgetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Budget in budgets to populate budgetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderBudgetNameSelector
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
    public V1beta1BudgetActionSpecForProviderBudgetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionPolicyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Policy in iam to populate policyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionPolicyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionPolicyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionPolicyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Policy in iam to populate policyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionPolicyArnSelector
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
    public V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionPolicyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionRolesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionRolesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionRolesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionRolesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Role in iam to populate roles.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionRolesSelector
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
    public V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionRolesSelectorPolicy? Policy { get; set; }
}

/// <summary>The AWS Identity and Access Management (IAM) action definition details. See IAM Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinition
{
    /// <summary>A list of groups to be attached. There must be at least one group.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the policy to be attached.</summary>
    [JsonPropertyName("policyArn")]
    public string? PolicyArn { get; set; }

    /// <summary>Reference to a Policy in iam to populate policyArn.</summary>
    [JsonPropertyName("policyArnRef")]
    public V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionPolicyArnRef? PolicyArnRef { get; set; }

    /// <summary>Selector for a Policy in iam to populate policyArn.</summary>
    [JsonPropertyName("policyArnSelector")]
    public V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionPolicyArnSelector? PolicyArnSelector { get; set; }

    /// <summary>A list of roles to be attached. There must be at least one role.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>References to Role in iam to populate roles.</summary>
    [JsonPropertyName("rolesRefs")]
    public IList<V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionRolesRefs>? RolesRefs { get; set; }

    /// <summary>Selector for a list of Role in iam to populate roles.</summary>
    [JsonPropertyName("rolesSelector")]
    public V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinitionRolesSelector? RolesSelector { get; set; }

    /// <summary>A list of users to be attached. There must be at least one user.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>The service control policies (SCPs) action definition details. See SCP Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionScpActionDefinition
{
    /// <summary>The policy ID attached.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>A list of target IDs.</summary>
    [JsonPropertyName("targetIds")]
    public IList<string>? TargetIds { get; set; }
}

/// <summary>The AWS Systems Manager (SSM) action definition details. See SSM Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinitionSsmActionDefinition
{
    /// <summary>The action subType. Valid values are STOP_EC2_INSTANCES or STOP_RDS_INSTANCES.</summary>
    [JsonPropertyName("actionSubType")]
    public string? ActionSubType { get; set; }

    /// <summary>The EC2 and RDS instance IDs.</summary>
    [JsonPropertyName("instanceIds")]
    public IList<string>? InstanceIds { get; set; }

    /// <summary>The Region to run the SSM document.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary>Specifies all of the type-specific parameters. See Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderDefinition
{
    /// <summary>The AWS Identity and Access Management (IAM) action definition details. See IAM Action Definition.</summary>
    [JsonPropertyName("iamActionDefinition")]
    public V1beta1BudgetActionSpecForProviderDefinitionIamActionDefinition? IamActionDefinition { get; set; }

    /// <summary>The service control policies (SCPs) action definition details. See SCP Action Definition.</summary>
    [JsonPropertyName("scpActionDefinition")]
    public V1beta1BudgetActionSpecForProviderDefinitionScpActionDefinition? ScpActionDefinition { get; set; }

    /// <summary>The AWS Systems Manager (SSM) action definition details. See SSM Action Definition.</summary>
    [JsonPropertyName("ssmActionDefinition")]
    public V1beta1BudgetActionSpecForProviderDefinitionSsmActionDefinition? SsmActionDefinition { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetActionSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderExecutionRoleArnSelector
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
    public V1beta1BudgetActionSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProviderSubscriber
{
    /// <summary>The address that AWS sends budget notifications to, either an SNS topic or an email.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The type of notification that AWS sends to a subscriber. Valid values are SNS or EMAIL.</summary>
    [JsonPropertyName("subscriptionType")]
    public string? SubscriptionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecForProvider
{
    /// <summary>The ID of the target account for budget. Will use current user's account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The trigger threshold of the action. See Action Threshold.</summary>
    [JsonPropertyName("actionThreshold")]
    public V1beta1BudgetActionSpecForProviderActionThreshold? ActionThreshold { get; set; }

    /// <summary>The type of action. This defines the type of tasks that can be carried out by this action. This field also determines the format for definition. Valid values are APPLY_IAM_POLICY, APPLY_SCP_POLICY, and RUN_SSM_DOCUMENTS.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>This specifies if the action needs manual or automatic approval. Valid values are AUTOMATIC and MANUAL.</summary>
    [JsonPropertyName("approvalModel")]
    public string? ApprovalModel { get; set; }

    /// <summary>The name of a budget.</summary>
    [JsonPropertyName("budgetName")]
    public string? BudgetName { get; set; }

    /// <summary>Reference to a Budget in budgets to populate budgetName.</summary>
    [JsonPropertyName("budgetNameRef")]
    public V1beta1BudgetActionSpecForProviderBudgetNameRef? BudgetNameRef { get; set; }

    /// <summary>Selector for a Budget in budgets to populate budgetName.</summary>
    [JsonPropertyName("budgetNameSelector")]
    public V1beta1BudgetActionSpecForProviderBudgetNameSelector? BudgetNameSelector { get; set; }

    /// <summary>Specifies all of the type-specific parameters. See Definition.</summary>
    [JsonPropertyName("definition")]
    public V1beta1BudgetActionSpecForProviderDefinition? Definition { get; set; }

    /// <summary>The role passed for action execution and reversion. Roles and actions must be in the same account.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1BudgetActionSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1BudgetActionSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>The type of a notification. Valid values are ACTUAL or FORECASTED.</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>A list of subscribers. See Subscriber.</summary>
    [JsonPropertyName("subscriber")]
    public IList<V1beta1BudgetActionSpecForProviderSubscriber>? Subscriber { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>The trigger threshold of the action. See Action Threshold.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderActionThreshold
{
    /// <summary>The type of threshold for a notification. Valid values are PERCENTAGE or ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("actionThresholdType")]
    public string? ActionThresholdType { get; set; }

    /// <summary>The threshold of a notification.</summary>
    [JsonPropertyName("actionThresholdValue")]
    public double? ActionThresholdValue { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderBudgetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Budget in budgets to populate budgetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderBudgetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetActionSpecInitProviderBudgetNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderBudgetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Budget in budgets to populate budgetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderBudgetNameSelector
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
    public V1beta1BudgetActionSpecInitProviderBudgetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionPolicyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Policy in iam to populate policyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionPolicyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionPolicyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionPolicyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Policy in iam to populate policyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionPolicyArnSelector
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
    public V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionPolicyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionRolesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionRolesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionRolesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionRolesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Role in iam to populate roles.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionRolesSelector
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
    public V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionRolesSelectorPolicy? Policy { get; set; }
}

/// <summary>The AWS Identity and Access Management (IAM) action definition details. See IAM Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinition
{
    /// <summary>A list of groups to be attached. There must be at least one group.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the policy to be attached.</summary>
    [JsonPropertyName("policyArn")]
    public string? PolicyArn { get; set; }

    /// <summary>Reference to a Policy in iam to populate policyArn.</summary>
    [JsonPropertyName("policyArnRef")]
    public V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionPolicyArnRef? PolicyArnRef { get; set; }

    /// <summary>Selector for a Policy in iam to populate policyArn.</summary>
    [JsonPropertyName("policyArnSelector")]
    public V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionPolicyArnSelector? PolicyArnSelector { get; set; }

    /// <summary>A list of roles to be attached. There must be at least one role.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>References to Role in iam to populate roles.</summary>
    [JsonPropertyName("rolesRefs")]
    public IList<V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionRolesRefs>? RolesRefs { get; set; }

    /// <summary>Selector for a list of Role in iam to populate roles.</summary>
    [JsonPropertyName("rolesSelector")]
    public V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinitionRolesSelector? RolesSelector { get; set; }

    /// <summary>A list of users to be attached. There must be at least one user.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>The service control policies (SCPs) action definition details. See SCP Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionScpActionDefinition
{
    /// <summary>The policy ID attached.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>A list of target IDs.</summary>
    [JsonPropertyName("targetIds")]
    public IList<string>? TargetIds { get; set; }
}

/// <summary>The AWS Systems Manager (SSM) action definition details. See SSM Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinitionSsmActionDefinition
{
    /// <summary>The action subType. Valid values are STOP_EC2_INSTANCES or STOP_RDS_INSTANCES.</summary>
    [JsonPropertyName("actionSubType")]
    public string? ActionSubType { get; set; }

    /// <summary>The EC2 and RDS instance IDs.</summary>
    [JsonPropertyName("instanceIds")]
    public IList<string>? InstanceIds { get; set; }
}

/// <summary>Specifies all of the type-specific parameters. See Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderDefinition
{
    /// <summary>The AWS Identity and Access Management (IAM) action definition details. See IAM Action Definition.</summary>
    [JsonPropertyName("iamActionDefinition")]
    public V1beta1BudgetActionSpecInitProviderDefinitionIamActionDefinition? IamActionDefinition { get; set; }

    /// <summary>The service control policies (SCPs) action definition details. See SCP Action Definition.</summary>
    [JsonPropertyName("scpActionDefinition")]
    public V1beta1BudgetActionSpecInitProviderDefinitionScpActionDefinition? ScpActionDefinition { get; set; }

    /// <summary>The AWS Systems Manager (SSM) action definition details. See SSM Action Definition.</summary>
    [JsonPropertyName("ssmActionDefinition")]
    public V1beta1BudgetActionSpecInitProviderDefinitionSsmActionDefinition? SsmActionDefinition { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetActionSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderExecutionRoleArnSelector
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
    public V1beta1BudgetActionSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProviderSubscriber
{
    /// <summary>The address that AWS sends budget notifications to, either an SNS topic or an email.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The type of notification that AWS sends to a subscriber. Valid values are SNS or EMAIL.</summary>
    [JsonPropertyName("subscriptionType")]
    public string? SubscriptionType { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecInitProvider
{
    /// <summary>The ID of the target account for budget. Will use current user's account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The trigger threshold of the action. See Action Threshold.</summary>
    [JsonPropertyName("actionThreshold")]
    public V1beta1BudgetActionSpecInitProviderActionThreshold? ActionThreshold { get; set; }

    /// <summary>The type of action. This defines the type of tasks that can be carried out by this action. This field also determines the format for definition. Valid values are APPLY_IAM_POLICY, APPLY_SCP_POLICY, and RUN_SSM_DOCUMENTS.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>This specifies if the action needs manual or automatic approval. Valid values are AUTOMATIC and MANUAL.</summary>
    [JsonPropertyName("approvalModel")]
    public string? ApprovalModel { get; set; }

    /// <summary>The name of a budget.</summary>
    [JsonPropertyName("budgetName")]
    public string? BudgetName { get; set; }

    /// <summary>Reference to a Budget in budgets to populate budgetName.</summary>
    [JsonPropertyName("budgetNameRef")]
    public V1beta1BudgetActionSpecInitProviderBudgetNameRef? BudgetNameRef { get; set; }

    /// <summary>Selector for a Budget in budgets to populate budgetName.</summary>
    [JsonPropertyName("budgetNameSelector")]
    public V1beta1BudgetActionSpecInitProviderBudgetNameSelector? BudgetNameSelector { get; set; }

    /// <summary>Specifies all of the type-specific parameters. See Definition.</summary>
    [JsonPropertyName("definition")]
    public V1beta1BudgetActionSpecInitProviderDefinition? Definition { get; set; }

    /// <summary>The role passed for action execution and reversion. Roles and actions must be in the same account.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1BudgetActionSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1BudgetActionSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>The type of a notification. Valid values are ACTUAL or FORECASTED.</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>A list of subscribers. See Subscriber.</summary>
    [JsonPropertyName("subscriber")]
    public IList<V1beta1BudgetActionSpecInitProviderSubscriber>? Subscriber { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BudgetActionSpec defines the desired state of BudgetAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BudgetActionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BudgetActionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BudgetActionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BudgetActionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The trigger threshold of the action. See Action Threshold.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatusAtProviderActionThreshold
{
    /// <summary>The type of threshold for a notification. Valid values are PERCENTAGE or ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("actionThresholdType")]
    public string? ActionThresholdType { get; set; }

    /// <summary>The threshold of a notification.</summary>
    [JsonPropertyName("actionThresholdValue")]
    public double? ActionThresholdValue { get; set; }
}

/// <summary>The AWS Identity and Access Management (IAM) action definition details. See IAM Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatusAtProviderDefinitionIamActionDefinition
{
    /// <summary>A list of groups to be attached. There must be at least one group.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the policy to be attached.</summary>
    [JsonPropertyName("policyArn")]
    public string? PolicyArn { get; set; }

    /// <summary>A list of roles to be attached. There must be at least one role.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>A list of users to be attached. There must be at least one user.</summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>The service control policies (SCPs) action definition details. See SCP Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatusAtProviderDefinitionScpActionDefinition
{
    /// <summary>The policy ID attached.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>A list of target IDs.</summary>
    [JsonPropertyName("targetIds")]
    public IList<string>? TargetIds { get; set; }
}

/// <summary>The AWS Systems Manager (SSM) action definition details. See SSM Action Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatusAtProviderDefinitionSsmActionDefinition
{
    /// <summary>The action subType. Valid values are STOP_EC2_INSTANCES or STOP_RDS_INSTANCES.</summary>
    [JsonPropertyName("actionSubType")]
    public string? ActionSubType { get; set; }

    /// <summary>The EC2 and RDS instance IDs.</summary>
    [JsonPropertyName("instanceIds")]
    public IList<string>? InstanceIds { get; set; }

    /// <summary>The Region to run the SSM document.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>Specifies all of the type-specific parameters. See Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatusAtProviderDefinition
{
    /// <summary>The AWS Identity and Access Management (IAM) action definition details. See IAM Action Definition.</summary>
    [JsonPropertyName("iamActionDefinition")]
    public V1beta1BudgetActionStatusAtProviderDefinitionIamActionDefinition? IamActionDefinition { get; set; }

    /// <summary>The service control policies (SCPs) action definition details. See SCP Action Definition.</summary>
    [JsonPropertyName("scpActionDefinition")]
    public V1beta1BudgetActionStatusAtProviderDefinitionScpActionDefinition? ScpActionDefinition { get; set; }

    /// <summary>The AWS Systems Manager (SSM) action definition details. See SSM Action Definition.</summary>
    [JsonPropertyName("ssmActionDefinition")]
    public V1beta1BudgetActionStatusAtProviderDefinitionSsmActionDefinition? SsmActionDefinition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatusAtProviderSubscriber
{
    /// <summary>The address that AWS sends budget notifications to, either an SNS topic or an email.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The type of notification that AWS sends to a subscriber. Valid values are SNS or EMAIL.</summary>
    [JsonPropertyName("subscriptionType")]
    public string? SubscriptionType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatusAtProvider
{
    /// <summary>The ID of the target account for budget. Will use current user's account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The id of the budget action.</summary>
    [JsonPropertyName("actionId")]
    public string? ActionId { get; set; }

    /// <summary>The trigger threshold of the action. See Action Threshold.</summary>
    [JsonPropertyName("actionThreshold")]
    public V1beta1BudgetActionStatusAtProviderActionThreshold? ActionThreshold { get; set; }

    /// <summary>The type of action. This defines the type of tasks that can be carried out by this action. This field also determines the format for definition. Valid values are APPLY_IAM_POLICY, APPLY_SCP_POLICY, and RUN_SSM_DOCUMENTS.</summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>This specifies if the action needs manual or automatic approval. Valid values are AUTOMATIC and MANUAL.</summary>
    [JsonPropertyName("approvalModel")]
    public string? ApprovalModel { get; set; }

    /// <summary>The ARN of the budget action.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The name of a budget.</summary>
    [JsonPropertyName("budgetName")]
    public string? BudgetName { get; set; }

    /// <summary>Specifies all of the type-specific parameters. See Definition.</summary>
    [JsonPropertyName("definition")]
    public V1beta1BudgetActionStatusAtProviderDefinition? Definition { get; set; }

    /// <summary>The role passed for action execution and reversion. Roles and actions must be in the same account.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>ID of resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of a notification. Valid values are ACTUAL or FORECASTED.</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>The status of the budget action.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A list of subscribers. See Subscriber.</summary>
    [JsonPropertyName("subscriber")]
    public IList<V1beta1BudgetActionStatusAtProviderSubscriber>? Subscriber { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatusConditions
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

/// <summary>BudgetActionStatus defines the observed state of BudgetAction.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetActionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BudgetActionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BudgetActionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BudgetAction is the Schema for the BudgetActions API. Provides a budget action resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BudgetAction : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BudgetActionSpec>, IStatus<V1beta1BudgetActionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetAction";
    public const string KubeGroup = "budgets.aws.m.upbound.io";
    public const string KubePluralName = "budgetactions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BudgetActionSpec defines the desired state of BudgetAction</summary>
    [JsonPropertyName("spec")]
    public V1beta1BudgetActionSpec Spec { get; set; }

    /// <summary>BudgetActionStatus defines the observed state of BudgetAction.</summary>
    [JsonPropertyName("status")]
    public V1beta1BudgetActionStatus? Status { get; set; }
}