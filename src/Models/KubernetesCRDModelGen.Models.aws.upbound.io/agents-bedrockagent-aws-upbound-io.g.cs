using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagent.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderAgentResourceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate agentResourceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderAgentResourceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentSpecForProviderAgentResourceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderAgentResourceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate agentResourceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderAgentResourceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentSpecForProviderAgentResourceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderGuardrailConfiguration
{
    /// <summary>Unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>Version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderMemoryConfiguration
{
    /// <summary>The type of memory being stored by the agent. See AWS API documentation for possible values.</summary>
    [JsonPropertyName("enabledMemoryTypes")]
    public IList<string>? EnabledMemoryTypes { get; set; }

    /// <summary>The number of days the agent is configured to retain the conversational context. Minimum value of 0, maximum value of 30.</summary>
    [JsonPropertyName("storageDays")]
    public double? StorageDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration
{
    /// <summary>Maximum number of tokens to allow in the generated response.</summary>
    [JsonPropertyName("maxLength")]
    public double? MaxLength { get; set; }

    /// <summary>List of stop sequences. A stop sequence is a sequence of characters that causes the model to stop generating the response.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Likelihood of the model selecting higher-probability options while generating a response. A lower value makes the model more likely to choose higher-probability options, while a higher value makes the model more likely to choose lower-probability options.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Number of top most-likely candidates, between 0 and 500, from which the model chooses the next token in the sequence.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

    /// <summary>Top percentage of the probability distribution of next tokens, between 0 and 1 (denoting 0% and 100%), from which the model chooses the next token in the sequence.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderPromptOverrideConfigurationPromptConfigurations
{
    /// <summary>prompt template with which to replace the default prompt template. You can use placeholder variables in the base prompt template to customize the prompt. For more information, see Prompt template placeholder variables.</summary>
    [JsonPropertyName("basePromptTemplate")]
    public string? BasePromptTemplate { get; set; }

    /// <summary>Inference parameters to use when the agent invokes a foundation model in the part of the agent sequence defined by the prompt_type. For more information, see Inference parameters for foundation models. See inference_configuration Block for details.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public IList<V1beta1AgentSpecForProviderPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration>? InferenceConfiguration { get; set; }

    /// <summary>Whether to override the default parser Lambda function when parsing the raw foundation model output in the part of the agent sequence defined by the prompt_type. If you set the argument as OVERRIDDEN, the override_lambda argument in the prompt_override_configuration block must be specified with the ARN of a Lambda function. Valid values: DEFAULT, OVERRIDDEN.</summary>
    [JsonPropertyName("parserMode")]
    public string? ParserMode { get; set; }

    /// <summary>Whether to override the default prompt template for this prompt_type. Set this argument to OVERRIDDEN to use the prompt that you provide in the base_prompt_template. If you leave it as DEFAULT, the agent uses a default prompt template. Valid values: DEFAULT, OVERRIDDEN.</summary>
    [JsonPropertyName("promptCreationMode")]
    public string? PromptCreationMode { get; set; }

    /// <summary>Whether to allow the agent to carry out the step specified in the prompt_type. If you set this argument to DISABLED, the agent skips that step. Valid Values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("promptState")]
    public string? PromptState { get; set; }

    /// <summary>Step in the agent sequence that this prompt configuration applies to. Valid values: PRE_PROCESSING, ORCHESTRATION, POST_PROCESSING, KNOWLEDGE_BASE_RESPONSE_GENERATION.</summary>
    [JsonPropertyName("promptType")]
    public string? PromptType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProviderPromptOverrideConfiguration
{
    /// <summary>ARN of the Lambda function to use when parsing the raw foundation model output in parts of the agent sequence. If you specify this field, at least one of the prompt_configurations block must contain a parser_mode value that is set to OVERRIDDEN.</summary>
    [JsonPropertyName("overrideLambda")]
    public string? OverrideLambda { get; set; }

    /// <summary>Configurations to override a prompt template in one part of an agent sequence. See prompt_configurations Block for details.</summary>
    [JsonPropertyName("promptConfigurations")]
    public IList<V1beta1AgentSpecForProviderPromptOverrideConfigurationPromptConfigurations>? PromptConfigurations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecForProvider
{
    /// <summary>Agents collaboration role. Valid values: SUPERVISOR, SUPERVISOR_ROUTER, DISABLED.</summary>
    [JsonPropertyName("agentCollaboration")]
    public string? AgentCollaboration { get; set; }

    /// <summary>Name of the agent.</summary>
    [JsonPropertyName("agentName")]
    public string? AgentName { get; set; }

    /// <summary>ARN of the IAM role with permissions to invoke API operations on the agent.</summary>
    [JsonPropertyName("agentResourceRoleArn")]
    public string? AgentResourceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate agentResourceRoleArn.</summary>
    [JsonPropertyName("agentResourceRoleArnRef")]
    public V1beta1AgentSpecForProviderAgentResourceRoleArnRef? AgentResourceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate agentResourceRoleArn.</summary>
    [JsonPropertyName("agentResourceRoleArnSelector")]
    public V1beta1AgentSpecForProviderAgentResourceRoleArnSelector? AgentResourceRoleArnSelector { get; set; }

    /// <summary>ARN of the AWS KMS key that encrypts the agent.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>Description of the agent.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Foundation model used for orchestration by the agent.</summary>
    [JsonPropertyName("foundationModel")]
    public string? FoundationModel { get; set; }

    /// <summary>Details about the guardrail associated with the agent. See guardrail_configuration Block for details.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public IList<V1beta1AgentSpecForProviderGuardrailConfiguration>? GuardrailConfiguration { get; set; }

    /// <summary>Number of seconds for which Amazon Bedrock keeps information about a user's conversation with the agent. A user interaction remains active for the amount of time specified. If no conversation occurs during this time, the session expires and Amazon Bedrock deletes any data provided before the timeout.</summary>
    [JsonPropertyName("idleSessionTtlInSeconds")]
    public double? IdleSessionTtlInSeconds { get; set; }

    /// <summary>Instructions that tell the agent what it should do and how it should interact with users. The valid range is 40 - 20000 characters.</summary>
    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    /// <summary>Configurations for the agent's ability to retain the conversational context.</summary>
    [JsonPropertyName("memoryConfiguration")]
    public IList<V1beta1AgentSpecForProviderMemoryConfiguration>? MemoryConfiguration { get; set; }

    /// <summary>Whether to prepare the agent after creation or modification. Defaults to true.</summary>
    [JsonPropertyName("prepareAgent")]
    public bool? PrepareAgent { get; set; }

    /// <summary>Configurations to override prompt templates in different parts of an agent sequence. For more information, see Advanced prompts. See prompt_override_configuration Block for details.</summary>
    [JsonPropertyName("promptOverrideConfiguration")]
    public IList<V1beta1AgentSpecForProviderPromptOverrideConfiguration>? PromptOverrideConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Whether the in-use check is skipped when deleting the agent.</summary>
    [JsonPropertyName("skipResourceInUseCheck")]
    public bool? SkipResourceInUseCheck { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderAgentResourceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate agentResourceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderAgentResourceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentSpecInitProviderAgentResourceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderAgentResourceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate agentResourceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderAgentResourceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentSpecInitProviderAgentResourceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderGuardrailConfiguration
{
    /// <summary>Unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>Version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderMemoryConfiguration
{
    /// <summary>The type of memory being stored by the agent. See AWS API documentation for possible values.</summary>
    [JsonPropertyName("enabledMemoryTypes")]
    public IList<string>? EnabledMemoryTypes { get; set; }

    /// <summary>The number of days the agent is configured to retain the conversational context. Minimum value of 0, maximum value of 30.</summary>
    [JsonPropertyName("storageDays")]
    public double? StorageDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration
{
    /// <summary>Maximum number of tokens to allow in the generated response.</summary>
    [JsonPropertyName("maxLength")]
    public double? MaxLength { get; set; }

    /// <summary>List of stop sequences. A stop sequence is a sequence of characters that causes the model to stop generating the response.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Likelihood of the model selecting higher-probability options while generating a response. A lower value makes the model more likely to choose higher-probability options, while a higher value makes the model more likely to choose lower-probability options.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Number of top most-likely candidates, between 0 and 500, from which the model chooses the next token in the sequence.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

    /// <summary>Top percentage of the probability distribution of next tokens, between 0 and 1 (denoting 0% and 100%), from which the model chooses the next token in the sequence.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderPromptOverrideConfigurationPromptConfigurations
{
    /// <summary>prompt template with which to replace the default prompt template. You can use placeholder variables in the base prompt template to customize the prompt. For more information, see Prompt template placeholder variables.</summary>
    [JsonPropertyName("basePromptTemplate")]
    public string? BasePromptTemplate { get; set; }

    /// <summary>Inference parameters to use when the agent invokes a foundation model in the part of the agent sequence defined by the prompt_type. For more information, see Inference parameters for foundation models. See inference_configuration Block for details.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public IList<V1beta1AgentSpecInitProviderPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration>? InferenceConfiguration { get; set; }

    /// <summary>Whether to override the default parser Lambda function when parsing the raw foundation model output in the part of the agent sequence defined by the prompt_type. If you set the argument as OVERRIDDEN, the override_lambda argument in the prompt_override_configuration block must be specified with the ARN of a Lambda function. Valid values: DEFAULT, OVERRIDDEN.</summary>
    [JsonPropertyName("parserMode")]
    public string? ParserMode { get; set; }

    /// <summary>Whether to override the default prompt template for this prompt_type. Set this argument to OVERRIDDEN to use the prompt that you provide in the base_prompt_template. If you leave it as DEFAULT, the agent uses a default prompt template. Valid values: DEFAULT, OVERRIDDEN.</summary>
    [JsonPropertyName("promptCreationMode")]
    public string? PromptCreationMode { get; set; }

    /// <summary>Whether to allow the agent to carry out the step specified in the prompt_type. If you set this argument to DISABLED, the agent skips that step. Valid Values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("promptState")]
    public string? PromptState { get; set; }

    /// <summary>Step in the agent sequence that this prompt configuration applies to. Valid values: PRE_PROCESSING, ORCHESTRATION, POST_PROCESSING, KNOWLEDGE_BASE_RESPONSE_GENERATION.</summary>
    [JsonPropertyName("promptType")]
    public string? PromptType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProviderPromptOverrideConfiguration
{
    /// <summary>ARN of the Lambda function to use when parsing the raw foundation model output in parts of the agent sequence. If you specify this field, at least one of the prompt_configurations block must contain a parser_mode value that is set to OVERRIDDEN.</summary>
    [JsonPropertyName("overrideLambda")]
    public string? OverrideLambda { get; set; }

    /// <summary>Configurations to override a prompt template in one part of an agent sequence. See prompt_configurations Block for details.</summary>
    [JsonPropertyName("promptConfigurations")]
    public IList<V1beta1AgentSpecInitProviderPromptOverrideConfigurationPromptConfigurations>? PromptConfigurations { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecInitProvider
{
    /// <summary>Agents collaboration role. Valid values: SUPERVISOR, SUPERVISOR_ROUTER, DISABLED.</summary>
    [JsonPropertyName("agentCollaboration")]
    public string? AgentCollaboration { get; set; }

    /// <summary>Name of the agent.</summary>
    [JsonPropertyName("agentName")]
    public string? AgentName { get; set; }

    /// <summary>ARN of the IAM role with permissions to invoke API operations on the agent.</summary>
    [JsonPropertyName("agentResourceRoleArn")]
    public string? AgentResourceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate agentResourceRoleArn.</summary>
    [JsonPropertyName("agentResourceRoleArnRef")]
    public V1beta1AgentSpecInitProviderAgentResourceRoleArnRef? AgentResourceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate agentResourceRoleArn.</summary>
    [JsonPropertyName("agentResourceRoleArnSelector")]
    public V1beta1AgentSpecInitProviderAgentResourceRoleArnSelector? AgentResourceRoleArnSelector { get; set; }

    /// <summary>ARN of the AWS KMS key that encrypts the agent.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>Description of the agent.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Foundation model used for orchestration by the agent.</summary>
    [JsonPropertyName("foundationModel")]
    public string? FoundationModel { get; set; }

    /// <summary>Details about the guardrail associated with the agent. See guardrail_configuration Block for details.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public IList<V1beta1AgentSpecInitProviderGuardrailConfiguration>? GuardrailConfiguration { get; set; }

    /// <summary>Number of seconds for which Amazon Bedrock keeps information about a user's conversation with the agent. A user interaction remains active for the amount of time specified. If no conversation occurs during this time, the session expires and Amazon Bedrock deletes any data provided before the timeout.</summary>
    [JsonPropertyName("idleSessionTtlInSeconds")]
    public double? IdleSessionTtlInSeconds { get; set; }

    /// <summary>Instructions that tell the agent what it should do and how it should interact with users. The valid range is 40 - 20000 characters.</summary>
    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    /// <summary>Configurations for the agent's ability to retain the conversational context.</summary>
    [JsonPropertyName("memoryConfiguration")]
    public IList<V1beta1AgentSpecInitProviderMemoryConfiguration>? MemoryConfiguration { get; set; }

    /// <summary>Whether to prepare the agent after creation or modification. Defaults to true.</summary>
    [JsonPropertyName("prepareAgent")]
    public bool? PrepareAgent { get; set; }

    /// <summary>Configurations to override prompt templates in different parts of an agent sequence. For more information, see Advanced prompts. See prompt_override_configuration Block for details.</summary>
    [JsonPropertyName("promptOverrideConfiguration")]
    public IList<V1beta1AgentSpecInitProviderPromptOverrideConfiguration>? PromptOverrideConfiguration { get; set; }

    /// <summary>Whether the in-use check is skipped when deleting the agent.</summary>
    [JsonPropertyName("skipResourceInUseCheck")]
    public bool? SkipResourceInUseCheck { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecProviderConfigRefPolicy
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
public partial class V1beta1AgentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1AgentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AgentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AgentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AgentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AgentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AgentSpec defines the desired state of Agent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AgentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AgentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AgentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AgentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AgentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentStatusAtProviderGuardrailConfiguration
{
    /// <summary>Unique identifier of the guardrail.</summary>
    [JsonPropertyName("guardrailIdentifier")]
    public string? GuardrailIdentifier { get; set; }

    /// <summary>Version of the guardrail.</summary>
    [JsonPropertyName("guardrailVersion")]
    public string? GuardrailVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentStatusAtProviderMemoryConfiguration
{
    /// <summary>The type of memory being stored by the agent. See AWS API documentation for possible values.</summary>
    [JsonPropertyName("enabledMemoryTypes")]
    public IList<string>? EnabledMemoryTypes { get; set; }

    /// <summary>The number of days the agent is configured to retain the conversational context. Minimum value of 0, maximum value of 30.</summary>
    [JsonPropertyName("storageDays")]
    public double? StorageDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentStatusAtProviderPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration
{
    /// <summary>Maximum number of tokens to allow in the generated response.</summary>
    [JsonPropertyName("maxLength")]
    public double? MaxLength { get; set; }

    /// <summary>List of stop sequences. A stop sequence is a sequence of characters that causes the model to stop generating the response.</summary>
    [JsonPropertyName("stopSequences")]
    public IList<string>? StopSequences { get; set; }

    /// <summary>Likelihood of the model selecting higher-probability options while generating a response. A lower value makes the model more likely to choose higher-probability options, while a higher value makes the model more likely to choose lower-probability options.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>Number of top most-likely candidates, between 0 and 500, from which the model chooses the next token in the sequence.</summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

    /// <summary>Top percentage of the probability distribution of next tokens, between 0 and 1 (denoting 0% and 100%), from which the model chooses the next token in the sequence.</summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentStatusAtProviderPromptOverrideConfigurationPromptConfigurations
{
    /// <summary>prompt template with which to replace the default prompt template. You can use placeholder variables in the base prompt template to customize the prompt. For more information, see Prompt template placeholder variables.</summary>
    [JsonPropertyName("basePromptTemplate")]
    public string? BasePromptTemplate { get; set; }

    /// <summary>Inference parameters to use when the agent invokes a foundation model in the part of the agent sequence defined by the prompt_type. For more information, see Inference parameters for foundation models. See inference_configuration Block for details.</summary>
    [JsonPropertyName("inferenceConfiguration")]
    public IList<V1beta1AgentStatusAtProviderPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration>? InferenceConfiguration { get; set; }

    /// <summary>Whether to override the default parser Lambda function when parsing the raw foundation model output in the part of the agent sequence defined by the prompt_type. If you set the argument as OVERRIDDEN, the override_lambda argument in the prompt_override_configuration block must be specified with the ARN of a Lambda function. Valid values: DEFAULT, OVERRIDDEN.</summary>
    [JsonPropertyName("parserMode")]
    public string? ParserMode { get; set; }

    /// <summary>Whether to override the default prompt template for this prompt_type. Set this argument to OVERRIDDEN to use the prompt that you provide in the base_prompt_template. If you leave it as DEFAULT, the agent uses a default prompt template. Valid values: DEFAULT, OVERRIDDEN.</summary>
    [JsonPropertyName("promptCreationMode")]
    public string? PromptCreationMode { get; set; }

    /// <summary>Whether to allow the agent to carry out the step specified in the prompt_type. If you set this argument to DISABLED, the agent skips that step. Valid Values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("promptState")]
    public string? PromptState { get; set; }

    /// <summary>Step in the agent sequence that this prompt configuration applies to. Valid values: PRE_PROCESSING, ORCHESTRATION, POST_PROCESSING, KNOWLEDGE_BASE_RESPONSE_GENERATION.</summary>
    [JsonPropertyName("promptType")]
    public string? PromptType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentStatusAtProviderPromptOverrideConfiguration
{
    /// <summary>ARN of the Lambda function to use when parsing the raw foundation model output in parts of the agent sequence. If you specify this field, at least one of the prompt_configurations block must contain a parser_mode value that is set to OVERRIDDEN.</summary>
    [JsonPropertyName("overrideLambda")]
    public string? OverrideLambda { get; set; }

    /// <summary>Configurations to override a prompt template in one part of an agent sequence. See prompt_configurations Block for details.</summary>
    [JsonPropertyName("promptConfigurations")]
    public IList<V1beta1AgentStatusAtProviderPromptOverrideConfigurationPromptConfigurations>? PromptConfigurations { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentStatusAtProvider
{
    /// <summary>ARN of the agent.</summary>
    [JsonPropertyName("agentArn")]
    public string? AgentArn { get; set; }

    /// <summary>Agents collaboration role. Valid values: SUPERVISOR, SUPERVISOR_ROUTER, DISABLED.</summary>
    [JsonPropertyName("agentCollaboration")]
    public string? AgentCollaboration { get; set; }

    /// <summary>Unique identifier of the agent.</summary>
    [JsonPropertyName("agentId")]
    public string? AgentId { get; set; }

    /// <summary>Name of the agent.</summary>
    [JsonPropertyName("agentName")]
    public string? AgentName { get; set; }

    /// <summary>ARN of the IAM role with permissions to invoke API operations on the agent.</summary>
    [JsonPropertyName("agentResourceRoleArn")]
    public string? AgentResourceRoleArn { get; set; }

    /// <summary>Version of the agent.</summary>
    [JsonPropertyName("agentVersion")]
    public string? AgentVersion { get; set; }

    /// <summary>ARN of the AWS KMS key that encrypts the agent.</summary>
    [JsonPropertyName("customerEncryptionKeyArn")]
    public string? CustomerEncryptionKeyArn { get; set; }

    /// <summary>Description of the agent.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Foundation model used for orchestration by the agent.</summary>
    [JsonPropertyName("foundationModel")]
    public string? FoundationModel { get; set; }

    /// <summary>Details about the guardrail associated with the agent. See guardrail_configuration Block for details.</summary>
    [JsonPropertyName("guardrailConfiguration")]
    public IList<V1beta1AgentStatusAtProviderGuardrailConfiguration>? GuardrailConfiguration { get; set; }

    /// <summary>Unique identifier of the agent.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Number of seconds for which Amazon Bedrock keeps information about a user's conversation with the agent. A user interaction remains active for the amount of time specified. If no conversation occurs during this time, the session expires and Amazon Bedrock deletes any data provided before the timeout.</summary>
    [JsonPropertyName("idleSessionTtlInSeconds")]
    public double? IdleSessionTtlInSeconds { get; set; }

    /// <summary>Instructions that tell the agent what it should do and how it should interact with users. The valid range is 40 - 20000 characters.</summary>
    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    /// <summary>Configurations for the agent's ability to retain the conversational context.</summary>
    [JsonPropertyName("memoryConfiguration")]
    public IList<V1beta1AgentStatusAtProviderMemoryConfiguration>? MemoryConfiguration { get; set; }

    /// <summary>Whether to prepare the agent after creation or modification. Defaults to true.</summary>
    [JsonPropertyName("prepareAgent")]
    public bool? PrepareAgent { get; set; }

    /// <summary>Timestamp of when the agent was last prepared.</summary>
    [JsonPropertyName("preparedAt")]
    public string? PreparedAt { get; set; }

    /// <summary>Configurations to override prompt templates in different parts of an agent sequence. For more information, see Advanced prompts. See prompt_override_configuration Block for details.</summary>
    [JsonPropertyName("promptOverrideConfiguration")]
    public IList<V1beta1AgentStatusAtProviderPromptOverrideConfiguration>? PromptOverrideConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Whether the in-use check is skipped when deleting the agent.</summary>
    [JsonPropertyName("skipResourceInUseCheck")]
    public bool? SkipResourceInUseCheck { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentStatusConditions
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

/// <summary>AgentStatus defines the observed state of Agent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AgentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AgentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AgentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Agent is the Schema for the Agents API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Agent : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AgentSpec>, IStatus<V1beta1AgentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Agent";
    public const string KubeGroup = "bedrockagent.aws.upbound.io";
    public const string KubePluralName = "agents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AgentSpec defines the desired state of Agent</summary>
    [JsonPropertyName("spec")]
    public V1beta1AgentSpec Spec { get; set; }

    /// <summary>AgentStatus defines the observed state of Agent.</summary>
    [JsonPropertyName("status")]
    public V1beta1AgentStatus? Status { get; set; }
}

/// <summary>Agent is the Schema for the Agents API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AgentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Agent>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AgentList";
    public const string KubeGroup = "bedrockagent.aws.upbound.io";
    public const string KubePluralName = "agents";
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
    public IList<V1beta1Agent> Items { get; set; }
}