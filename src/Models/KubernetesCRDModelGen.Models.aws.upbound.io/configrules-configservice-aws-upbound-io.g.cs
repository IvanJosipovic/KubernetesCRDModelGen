using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.configservice.aws.upbound.io;
public enum V1beta1ConfigRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecForProviderEvaluationMode
{
    /// <summary>The mode of an evaluation.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecForProviderScope
{
    /// <summary>The IDs of the only AWS resource that you want to trigger an evaluation for the rule. If you specify a resource ID, you must specify one resource type for compliance_resource_types.</summary>
    [JsonPropertyName("complianceResourceId")]
    public string? ComplianceResourceId { get; set; }

    /// <summary>A list of resource types of only those AWS resources that you want to trigger an evaluation for the ruleE.g., AWS::EC2::Instance. You can only specify one type if you also specify a resource ID for compliance_resource_id. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("complianceResourceTypes")]
    public IList<string>? ComplianceResourceTypes { get; set; }

    /// <summary>The tag key that is applied to only those AWS resources that you want you want to trigger an evaluation for the rule.</summary>
    [JsonPropertyName("tagKey")]
    public string? TagKey { get; set; }

    /// <summary>The tag value applied to only those AWS resources that you want to trigger an evaluation for the rule.</summary>
    [JsonPropertyName("tagValue")]
    public string? TagValue { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecForProviderSourceCustomPolicyDetails
{
    /// <summary>The boolean expression for enabling debug logging for your Config Custom Policy rule. The default value is false.</summary>
    [JsonPropertyName("enableDebugLogDelivery")]
    public bool? EnableDebugLogDelivery { get; set; }

    /// <summary>The runtime system for your Config Custom Policy rule. Guard is a policy-as-code language that allows you to write policies that are enforced by Config Custom Policy rules. For more information about Guard, see the Guard GitHub Repository.</summary>
    [JsonPropertyName("policyRuntime")]
    public string? PolicyRuntime { get; set; }

    /// <summary>The policy definition containing the logic for your Config Custom Policy rule.</summary>
    [JsonPropertyName("policyText")]
    public string? PolicyText { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecForProviderSourceSourceDetail
{
    /// <summary>The source of the event, such as an AWS service, that triggers AWS Config to evaluate your AWSresources. This defaults to aws.config and is the only valid value.</summary>
    [JsonPropertyName("eventSource")]
    public string? EventSource { get; set; }

    /// <summary>The maximum frequency with which AWS Config runs evaluations for a rule.</summary>
    [JsonPropertyName("maximumExecutionFrequency")]
    public string? MaximumExecutionFrequency { get; set; }

    /// <summary>The type of notification that triggers AWS Config to run an evaluation for a rule. You canspecify the following notification types:</summary>
    [JsonPropertyName("messageType")]
    public string? MessageType { get; set; }
}

public enum V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRefPolicyResolutionEnum>))]
    public V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRefPolicyResolveEnum>))]
    public V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate sourceIdentifier.</summary>
public partial class V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRefPolicy? Policy { get; set; }
}

public enum V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelectorPolicyResolutionEnum>))]
    public V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelectorPolicyResolveEnum>))]
    public V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate sourceIdentifier.</summary>
public partial class V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecForProviderSource
{
    /// <summary>Provides the runtime system, policy definition, and whether debug logging is enabled. Required when owner is set to CUSTOM_POLICY. See Custom Policy Details Below.</summary>
    [JsonPropertyName("customPolicyDetails")]
    public IList<V1beta1ConfigRuleSpecForProviderSourceCustomPolicyDetails>? CustomPolicyDetails { get; set; }

    /// <summary>Indicates whether AWS or the customer owns and manages the AWS Config rule. Valid values are AWS, CUSTOM_LAMBDA or CUSTOM_POLICY. For more information about managed rules, see the AWS Config Managed Rules documentation. For more information about custom rules, see the AWS Config Custom Rules documentation. Custom Lambda Functions require permissions to allow the AWS Config service to invoke them, e.g., via the aws_lambda_permission resource.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Provides the source and type of the event that causes AWS Config to evaluate your AWS resources. Only valid if owner is CUSTOM_LAMBDA or CUSTOM_POLICY. See Source Detail Below.</summary>
    [JsonPropertyName("sourceDetail")]
    public IList<V1beta1ConfigRuleSpecForProviderSourceSourceDetail>? SourceDetail { get; set; }

    /// <summary>For AWS Config managed rules, a predefined identifier, e.g IAM_PASSWORD_POLICY. For custom Lambda rules, the identifier is the ARN of the Lambda Function, such as arn:aws:lambda:us-east-1:123456789012:function:custom_rule_name or the arn attribute of the aws_lambda_function resource.</summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>Reference to a Function in lambda to populate sourceIdentifier.</summary>
    [JsonPropertyName("sourceIdentifierRef")]
    public V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierRef? SourceIdentifierRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate sourceIdentifier.</summary>
    [JsonPropertyName("sourceIdentifierSelector")]
    public V1beta1ConfigRuleSpecForProviderSourceSourceIdentifierSelector? SourceIdentifierSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecForProvider
{
    /// <summary>Description of the rule</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The modes the Config rule can be evaluated in. See Evaluation Mode for more details.</summary>
    [JsonPropertyName("evaluationMode")]
    public IList<V1beta1ConfigRuleSpecForProviderEvaluationMode>? EvaluationMode { get; set; }

    /// <summary>A string in JSON format that is passed to the AWS Config rule Lambda function.</summary>
    [JsonPropertyName("inputParameters")]
    public string? InputParameters { get; set; }

    /// <summary>The maximum frequency with which AWS Config runs evaluations for a rule.</summary>
    [JsonPropertyName("maximumExecutionFrequency")]
    public string? MaximumExecutionFrequency { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Scope defines which resources can trigger an evaluation for the rule. See Scope Below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1ConfigRuleSpecForProviderScope>? Scope { get; set; }

    /// <summary>Source specifies the rule owner, the rule identifier, and the notifications that cause the function to evaluate your AWS resources. See Source Below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1ConfigRuleSpecForProviderSource>? Source { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecInitProviderEvaluationMode
{
    /// <summary>The mode of an evaluation.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecInitProviderScope
{
    /// <summary>The IDs of the only AWS resource that you want to trigger an evaluation for the rule. If you specify a resource ID, you must specify one resource type for compliance_resource_types.</summary>
    [JsonPropertyName("complianceResourceId")]
    public string? ComplianceResourceId { get; set; }

    /// <summary>A list of resource types of only those AWS resources that you want to trigger an evaluation for the ruleE.g., AWS::EC2::Instance. You can only specify one type if you also specify a resource ID for compliance_resource_id. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("complianceResourceTypes")]
    public IList<string>? ComplianceResourceTypes { get; set; }

    /// <summary>The tag key that is applied to only those AWS resources that you want you want to trigger an evaluation for the rule.</summary>
    [JsonPropertyName("tagKey")]
    public string? TagKey { get; set; }

    /// <summary>The tag value applied to only those AWS resources that you want to trigger an evaluation for the rule.</summary>
    [JsonPropertyName("tagValue")]
    public string? TagValue { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecInitProviderSourceCustomPolicyDetails
{
    /// <summary>The boolean expression for enabling debug logging for your Config Custom Policy rule. The default value is false.</summary>
    [JsonPropertyName("enableDebugLogDelivery")]
    public bool? EnableDebugLogDelivery { get; set; }

    /// <summary>The runtime system for your Config Custom Policy rule. Guard is a policy-as-code language that allows you to write policies that are enforced by Config Custom Policy rules. For more information about Guard, see the Guard GitHub Repository.</summary>
    [JsonPropertyName("policyRuntime")]
    public string? PolicyRuntime { get; set; }

    /// <summary>The policy definition containing the logic for your Config Custom Policy rule.</summary>
    [JsonPropertyName("policyText")]
    public string? PolicyText { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecInitProviderSourceSourceDetail
{
    /// <summary>The source of the event, such as an AWS service, that triggers AWS Config to evaluate your AWSresources. This defaults to aws.config and is the only valid value.</summary>
    [JsonPropertyName("eventSource")]
    public string? EventSource { get; set; }

    /// <summary>The maximum frequency with which AWS Config runs evaluations for a rule.</summary>
    [JsonPropertyName("maximumExecutionFrequency")]
    public string? MaximumExecutionFrequency { get; set; }

    /// <summary>The type of notification that triggers AWS Config to run an evaluation for a rule. You canspecify the following notification types:</summary>
    [JsonPropertyName("messageType")]
    public string? MessageType { get; set; }
}

public enum V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRefPolicyResolutionEnum>))]
    public V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRefPolicyResolveEnum>))]
    public V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate sourceIdentifier.</summary>
public partial class V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRefPolicy? Policy { get; set; }
}

public enum V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelectorPolicyResolutionEnum>))]
    public V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelectorPolicyResolveEnum>))]
    public V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate sourceIdentifier.</summary>
public partial class V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleSpecInitProviderSource
{
    /// <summary>Provides the runtime system, policy definition, and whether debug logging is enabled. Required when owner is set to CUSTOM_POLICY. See Custom Policy Details Below.</summary>
    [JsonPropertyName("customPolicyDetails")]
    public IList<V1beta1ConfigRuleSpecInitProviderSourceCustomPolicyDetails>? CustomPolicyDetails { get; set; }

    /// <summary>Indicates whether AWS or the customer owns and manages the AWS Config rule. Valid values are AWS, CUSTOM_LAMBDA or CUSTOM_POLICY. For more information about managed rules, see the AWS Config Managed Rules documentation. For more information about custom rules, see the AWS Config Custom Rules documentation. Custom Lambda Functions require permissions to allow the AWS Config service to invoke them, e.g., via the aws_lambda_permission resource.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Provides the source and type of the event that causes AWS Config to evaluate your AWS resources. Only valid if owner is CUSTOM_LAMBDA or CUSTOM_POLICY. See Source Detail Below.</summary>
    [JsonPropertyName("sourceDetail")]
    public IList<V1beta1ConfigRuleSpecInitProviderSourceSourceDetail>? SourceDetail { get; set; }

    /// <summary>For AWS Config managed rules, a predefined identifier, e.g IAM_PASSWORD_POLICY. For custom Lambda rules, the identifier is the ARN of the Lambda Function, such as arn:aws:lambda:us-east-1:123456789012:function:custom_rule_name or the arn attribute of the aws_lambda_function resource.</summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>Reference to a Function in lambda to populate sourceIdentifier.</summary>
    [JsonPropertyName("sourceIdentifierRef")]
    public V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierRef? SourceIdentifierRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate sourceIdentifier.</summary>
    [JsonPropertyName("sourceIdentifierSelector")]
    public V1beta1ConfigRuleSpecInitProviderSourceSourceIdentifierSelector? SourceIdentifierSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ConfigRuleSpecInitProvider
{
    /// <summary>Description of the rule</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The modes the Config rule can be evaluated in. See Evaluation Mode for more details.</summary>
    [JsonPropertyName("evaluationMode")]
    public IList<V1beta1ConfigRuleSpecInitProviderEvaluationMode>? EvaluationMode { get; set; }

    /// <summary>A string in JSON format that is passed to the AWS Config rule Lambda function.</summary>
    [JsonPropertyName("inputParameters")]
    public string? InputParameters { get; set; }

    /// <summary>The maximum frequency with which AWS Config runs evaluations for a rule.</summary>
    [JsonPropertyName("maximumExecutionFrequency")]
    public string? MaximumExecutionFrequency { get; set; }

    /// <summary>Scope defines which resources can trigger an evaluation for the rule. See Scope Below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1ConfigRuleSpecInitProviderScope>? Scope { get; set; }

    /// <summary>Source specifies the rule owner, the rule identifier, and the notifications that cause the function to evaluate your AWS resources. See Source Below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1ConfigRuleSpecInitProviderSource>? Source { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1ConfigRuleSpecManagementPoliciesEnum
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

public enum V1beta1ConfigRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConfigRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConfigRuleSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ConfigRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ConfigRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ConfigRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ConfigRuleSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ConfigRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ConfigRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ConfigRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ConfigRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ConfigRuleSpec defines the desired state of ConfigRule</summary>
public partial class V1beta1ConfigRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConfigRuleSpecDeletionPolicyEnum>))]
    public V1beta1ConfigRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConfigRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConfigRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ConfigRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConfigRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ConfigRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConfigRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleStatusAtProviderEvaluationMode
{
    /// <summary>The mode of an evaluation.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleStatusAtProviderScope
{
    /// <summary>The IDs of the only AWS resource that you want to trigger an evaluation for the rule. If you specify a resource ID, you must specify one resource type for compliance_resource_types.</summary>
    [JsonPropertyName("complianceResourceId")]
    public string? ComplianceResourceId { get; set; }

    /// <summary>A list of resource types of only those AWS resources that you want to trigger an evaluation for the ruleE.g., AWS::EC2::Instance. You can only specify one type if you also specify a resource ID for compliance_resource_id. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("complianceResourceTypes")]
    public IList<string>? ComplianceResourceTypes { get; set; }

    /// <summary>The tag key that is applied to only those AWS resources that you want you want to trigger an evaluation for the rule.</summary>
    [JsonPropertyName("tagKey")]
    public string? TagKey { get; set; }

    /// <summary>The tag value applied to only those AWS resources that you want to trigger an evaluation for the rule.</summary>
    [JsonPropertyName("tagValue")]
    public string? TagValue { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleStatusAtProviderSourceCustomPolicyDetails
{
    /// <summary>The boolean expression for enabling debug logging for your Config Custom Policy rule. The default value is false.</summary>
    [JsonPropertyName("enableDebugLogDelivery")]
    public bool? EnableDebugLogDelivery { get; set; }

    /// <summary>The runtime system for your Config Custom Policy rule. Guard is a policy-as-code language that allows you to write policies that are enforced by Config Custom Policy rules. For more information about Guard, see the Guard GitHub Repository.</summary>
    [JsonPropertyName("policyRuntime")]
    public string? PolicyRuntime { get; set; }

    /// <summary>The policy definition containing the logic for your Config Custom Policy rule.</summary>
    [JsonPropertyName("policyText")]
    public string? PolicyText { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleStatusAtProviderSourceSourceDetail
{
    /// <summary>The source of the event, such as an AWS service, that triggers AWS Config to evaluate your AWSresources. This defaults to aws.config and is the only valid value.</summary>
    [JsonPropertyName("eventSource")]
    public string? EventSource { get; set; }

    /// <summary>The maximum frequency with which AWS Config runs evaluations for a rule.</summary>
    [JsonPropertyName("maximumExecutionFrequency")]
    public string? MaximumExecutionFrequency { get; set; }

    /// <summary>The type of notification that triggers AWS Config to run an evaluation for a rule. You canspecify the following notification types:</summary>
    [JsonPropertyName("messageType")]
    public string? MessageType { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleStatusAtProviderSource
{
    /// <summary>Provides the runtime system, policy definition, and whether debug logging is enabled. Required when owner is set to CUSTOM_POLICY. See Custom Policy Details Below.</summary>
    [JsonPropertyName("customPolicyDetails")]
    public IList<V1beta1ConfigRuleStatusAtProviderSourceCustomPolicyDetails>? CustomPolicyDetails { get; set; }

    /// <summary>Indicates whether AWS or the customer owns and manages the AWS Config rule. Valid values are AWS, CUSTOM_LAMBDA or CUSTOM_POLICY. For more information about managed rules, see the AWS Config Managed Rules documentation. For more information about custom rules, see the AWS Config Custom Rules documentation. Custom Lambda Functions require permissions to allow the AWS Config service to invoke them, e.g., via the aws_lambda_permission resource.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Provides the source and type of the event that causes AWS Config to evaluate your AWS resources. Only valid if owner is CUSTOM_LAMBDA or CUSTOM_POLICY. See Source Detail Below.</summary>
    [JsonPropertyName("sourceDetail")]
    public IList<V1beta1ConfigRuleStatusAtProviderSourceSourceDetail>? SourceDetail { get; set; }

    /// <summary>For AWS Config managed rules, a predefined identifier, e.g IAM_PASSWORD_POLICY. For custom Lambda rules, the identifier is the ARN of the Lambda Function, such as arn:aws:lambda:us-east-1:123456789012:function:custom_rule_name or the arn attribute of the aws_lambda_function resource.</summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }
}

/// <summary></summary>
public partial class V1beta1ConfigRuleStatusAtProvider
{
    /// <summary>The ARN of the config rule</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the rule</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The modes the Config rule can be evaluated in. See Evaluation Mode for more details.</summary>
    [JsonPropertyName("evaluationMode")]
    public IList<V1beta1ConfigRuleStatusAtProviderEvaluationMode>? EvaluationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A string in JSON format that is passed to the AWS Config rule Lambda function.</summary>
    [JsonPropertyName("inputParameters")]
    public string? InputParameters { get; set; }

    /// <summary>The maximum frequency with which AWS Config runs evaluations for a rule.</summary>
    [JsonPropertyName("maximumExecutionFrequency")]
    public string? MaximumExecutionFrequency { get; set; }

    /// <summary>The ID of the config rule</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Scope defines which resources can trigger an evaluation for the rule. See Scope Below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1ConfigRuleStatusAtProviderScope>? Scope { get; set; }

    /// <summary>Source specifies the rule owner, the rule identifier, and the notifications that cause the function to evaluate your AWS resources. See Source Below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1ConfigRuleStatusAtProviderSource>? Source { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ConfigRuleStatusConditions
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

/// <summary>ConfigRuleStatus defines the observed state of ConfigRule.</summary>
public partial class V1beta1ConfigRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConfigRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConfigRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ConfigRule is the Schema for the ConfigRules API. Provides an AWS Config Rule.</summary>
public partial class V1beta1ConfigRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConfigRuleSpec>, IStatus<V1beta1ConfigRuleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigRule";
    public const string KubeGroup = "configservice.aws.upbound.io";
    public const string KubePluralName = "configrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigRuleSpec defines the desired state of ConfigRule</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConfigRuleSpec Spec { get; set; }

    /// <summary>ConfigRuleStatus defines the observed state of ConfigRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConfigRuleStatus? Status { get; set; }
}