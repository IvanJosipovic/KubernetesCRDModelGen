using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codepipeline.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderArtifactStoreEncryptionKey
{
    /// <summary>The KMS key ARN or ID</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of key; currently only KMS is supported</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderArtifactStoreLocationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderArtifactStore
{
    /// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don't specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public IList<V1beta1CodepipelineSpecForProviderArtifactStoreEncryptionKey>? EncryptionKey { get; set; }

    /// <summary>The location where AWS CodePipeline stores artifacts for a pipeline; currently only S3 is supported.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationRef")]
    public V1beta1CodepipelineSpecForProviderArtifactStoreLocationRef? LocationRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationSelector")]
    public V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelector? LocationSelector { get; set; }

    /// <summary>The region where the artifact store is located. Required for a cross-region CodePipeline, do not provide for a single-region CodePipeline.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The type of the artifact store, such as Amazon S3</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageAction
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The action declaration's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace all output variables will be accessed from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>A list of artifact names to output. Output artifact names must be unique within a pipeline.</summary>
    [JsonPropertyName("outputArtifacts")]
    public IList<string>? OutputArtifacts { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The order in which actions are run.</summary>
    [JsonPropertyName("runOrder")]
    public double? RunOrder { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageBeforeEntryConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageBeforeEntryConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineSpecForProviderStageBeforeEntryConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageBeforeEntryCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineSpecForProviderStageBeforeEntryConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageBeforeEntry
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineSpecForProviderStageBeforeEntryCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnFailureConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnFailureConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnFailureConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnFailureCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnFailureConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnFailureRetryConfiguration
{
    /// <summary>The method that you want to configure for automatic stage retry on stage failure. You can specify to retry only failed action in the stage or all actions in the stage. Possible values are FAILED_ACTIONS and ALL_ACTIONS.</summary>
    [JsonPropertyName("retryMode")]
    public string? RetryMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnFailure
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnFailureCondition>? Condition { get; set; }

    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
    [JsonPropertyName("retryConfiguration")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnFailureRetryConfiguration>? RetryConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnSuccessConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnSuccessConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnSuccessConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnSuccessCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnSuccessConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStageOnSuccess
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnSuccessCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1CodepipelineSpecForProviderStageAction>? Action { get; set; }

    /// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
    [JsonPropertyName("beforeEntry")]
    public IList<V1beta1CodepipelineSpecForProviderStageBeforeEntry>? BeforeEntry { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnFailure>? OnFailure { get; set; }

    /// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1CodepipelineSpecForProviderStageOnSuccess>? OnSuccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPullRequestBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPullRequestFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPullRequest
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPullRequestBranches>? Branches { get; set; }

    /// <summary>A list that specifies which pull request events to filter on (opened, updated, closed) for the trigger configuration. Possible values are OPEN, UPDATED  and CLOSED.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPullRequestFilePaths>? FilePaths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPushBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPushFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPushTags
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPush
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPushBranches>? Branches { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPushFilePaths>? FilePaths { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPushTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTriggerGitConfiguration
{
    /// <summary>The field where the repository event that will start the pipeline is specified as pull requests. A pull_request block is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPullRequest>? PullRequest { get; set; }

    /// <summary>The field where the repository event that will start the pipeline, such as pushing Git tags, is specified with details. A push block is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1CodepipelineSpecForProviderTriggerGitConfigurationPush>? Push { get; set; }

    /// <summary>The name of the pipeline source action where the trigger configuration, such as Git tags, is specified. The trigger configuration will start the pipeline upon the specified change only.</summary>
    [JsonPropertyName("sourceActionName")]
    public string? SourceActionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderTrigger
{
    /// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
    [JsonPropertyName("gitConfiguration")]
    public IList<V1beta1CodepipelineSpecForProviderTriggerGitConfiguration>? GitConfiguration { get; set; }

    /// <summary>The source provider for the event. Possible value is CodeStarSourceConnection.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderVariable
{
    /// <summary>The default value of a pipeline-level variable.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The description of a pipeline-level variable.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProvider
{
    /// <summary>One or more artifact_store blocks. Artifact stores are documented below.</summary>
    [JsonPropertyName("artifactStore")]
    public IList<V1beta1CodepipelineSpecForProviderArtifactStore>? ArtifactStore { get; set; }

    /// <summary>The method that the pipeline will use to handle multiple executions. The default mode is SUPERSEDED. For value values, refer to the AWS documentation.</summary>
    [JsonPropertyName("executionMode")]
    public string? ExecutionMode { get; set; }

    /// <summary>Type of the pipeline. Possible values are: V1 and V2. Default value is V1.</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1CodepipelineSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1CodepipelineSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>(Minimum of at least two stage blocks is required) A stage block. Stages are documented below.</summary>
    [JsonPropertyName("stage")]
    public IList<V1beta1CodepipelineSpecForProviderStage>? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trigger block. Valid only when pipeline_type is V2. Triggers are documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1CodepipelineSpecForProviderTrigger>? Trigger { get; set; }

    /// <summary>A pipeline-level variable block. Valid only when pipeline_type is V2. Variable are documented below.</summary>
    [JsonPropertyName("variable")]
    public IList<V1beta1CodepipelineSpecForProviderVariable>? Variable { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderArtifactStoreEncryptionKey
{
    /// <summary>The KMS key ARN or ID</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of key; currently only KMS is supported</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderArtifactStore
{
    /// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don't specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public IList<V1beta1CodepipelineSpecInitProviderArtifactStoreEncryptionKey>? EncryptionKey { get; set; }

    /// <summary>The location where AWS CodePipeline stores artifacts for a pipeline; currently only S3 is supported.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationRef")]
    public V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRef? LocationRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate location.</summary>
    [JsonPropertyName("locationSelector")]
    public V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelector? LocationSelector { get; set; }

    /// <summary>The type of the artifact store, such as Amazon S3</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageAction
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The action declaration's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace all output variables will be accessed from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>A list of artifact names to output. Output artifact names must be unique within a pipeline.</summary>
    [JsonPropertyName("outputArtifacts")]
    public IList<string>? OutputArtifacts { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The order in which actions are run.</summary>
    [JsonPropertyName("runOrder")]
    public double? RunOrder { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageBeforeEntryConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageBeforeEntryConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineSpecInitProviderStageBeforeEntryConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageBeforeEntryCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineSpecInitProviderStageBeforeEntryConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageBeforeEntry
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineSpecInitProviderStageBeforeEntryCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnFailureConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnFailureConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnFailureConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnFailureCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnFailureConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnFailureRetryConfiguration
{
    /// <summary>The method that you want to configure for automatic stage retry on stage failure. You can specify to retry only failed action in the stage or all actions in the stage. Possible values are FAILED_ACTIONS and ALL_ACTIONS.</summary>
    [JsonPropertyName("retryMode")]
    public string? RetryMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnFailure
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnFailureCondition>? Condition { get; set; }

    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
    [JsonPropertyName("retryConfiguration")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnFailureRetryConfiguration>? RetryConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnSuccessConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnSuccessConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnSuccessConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnSuccessCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnSuccessConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStageOnSuccess
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnSuccessCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1CodepipelineSpecInitProviderStageAction>? Action { get; set; }

    /// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
    [JsonPropertyName("beforeEntry")]
    public IList<V1beta1CodepipelineSpecInitProviderStageBeforeEntry>? BeforeEntry { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnFailure>? OnFailure { get; set; }

    /// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1CodepipelineSpecInitProviderStageOnSuccess>? OnSuccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPullRequestBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPullRequestFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPullRequest
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPullRequestBranches>? Branches { get; set; }

    /// <summary>A list that specifies which pull request events to filter on (opened, updated, closed) for the trigger configuration. Possible values are OPEN, UPDATED  and CLOSED.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPullRequestFilePaths>? FilePaths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPushBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPushFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPushTags
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPush
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPushBranches>? Branches { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPushFilePaths>? FilePaths { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPushTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTriggerGitConfiguration
{
    /// <summary>The field where the repository event that will start the pipeline is specified as pull requests. A pull_request block is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPullRequest>? PullRequest { get; set; }

    /// <summary>The field where the repository event that will start the pipeline, such as pushing Git tags, is specified with details. A push block is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1CodepipelineSpecInitProviderTriggerGitConfigurationPush>? Push { get; set; }

    /// <summary>The name of the pipeline source action where the trigger configuration, such as Git tags, is specified. The trigger configuration will start the pipeline upon the specified change only.</summary>
    [JsonPropertyName("sourceActionName")]
    public string? SourceActionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderTrigger
{
    /// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
    [JsonPropertyName("gitConfiguration")]
    public IList<V1beta1CodepipelineSpecInitProviderTriggerGitConfiguration>? GitConfiguration { get; set; }

    /// <summary>The source provider for the event. Possible value is CodeStarSourceConnection.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderVariable
{
    /// <summary>The default value of a pipeline-level variable.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The description of a pipeline-level variable.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProvider
{
    /// <summary>One or more artifact_store blocks. Artifact stores are documented below.</summary>
    [JsonPropertyName("artifactStore")]
    public IList<V1beta1CodepipelineSpecInitProviderArtifactStore>? ArtifactStore { get; set; }

    /// <summary>The method that the pipeline will use to handle multiple executions. The default mode is SUPERSEDED. For value values, refer to the AWS documentation.</summary>
    [JsonPropertyName("executionMode")]
    public string? ExecutionMode { get; set; }

    /// <summary>Type of the pipeline. Possible values are: V1 and V2. Default value is V1.</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1CodepipelineSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1CodepipelineSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>(Minimum of at least two stage blocks is required) A stage block. Stages are documented below.</summary>
    [JsonPropertyName("stage")]
    public IList<V1beta1CodepipelineSpecInitProviderStage>? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trigger block. Valid only when pipeline_type is V2. Triggers are documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1CodepipelineSpecInitProviderTrigger>? Trigger { get; set; }

    /// <summary>A pipeline-level variable block. Valid only when pipeline_type is V2. Variable are documented below.</summary>
    [JsonPropertyName("variable")]
    public IList<V1beta1CodepipelineSpecInitProviderVariable>? Variable { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecProviderConfigRefPolicy
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
public partial class V1beta1CodepipelineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CodepipelineSpec defines the desired state of Codepipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CodepipelineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CodepipelineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CodepipelineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CodepipelineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderArtifactStoreEncryptionKey
{
    /// <summary>The KMS key ARN or ID</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of key; currently only KMS is supported</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderArtifactStore
{
    /// <summary>The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don't specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An encryption_key block is documented below.</summary>
    [JsonPropertyName("encryptionKey")]
    public IList<V1beta1CodepipelineStatusAtProviderArtifactStoreEncryptionKey>? EncryptionKey { get; set; }

    /// <summary>The location where AWS CodePipeline stores artifacts for a pipeline; currently only S3 is supported.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The region where the artifact store is located. Required for a cross-region CodePipeline, do not provide for a single-region CodePipeline.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The type of the artifact store, such as Amazon S3</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageAction
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The action declaration's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace all output variables will be accessed from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>A list of artifact names to output. Output artifact names must be unique within a pipeline.</summary>
    [JsonPropertyName("outputArtifacts")]
    public IList<string>? OutputArtifacts { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The order in which actions are run.</summary>
    [JsonPropertyName("runOrder")]
    public double? RunOrder { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageBeforeEntryConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageBeforeEntryConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineStatusAtProviderStageBeforeEntryConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageBeforeEntryCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineStatusAtProviderStageBeforeEntryConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageBeforeEntry
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineStatusAtProviderStageBeforeEntryCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnFailureConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnFailureConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnFailureConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnFailureCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnFailureConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnFailureRetryConfiguration
{
    /// <summary>The method that you want to configure for automatic stage retry on stage failure. You can specify to retry only failed action in the stage or all actions in the stage. Possible values are FAILED_ACTIONS and ALL_ACTIONS.</summary>
    [JsonPropertyName("retryMode")]
    public string? RetryMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnFailure
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnFailureCondition>? Condition { get; set; }

    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The retry configuration specifies automatic retry for a failed stage, along with the configured retry mode. Defined as a retry_configuration block below.</summary>
    [JsonPropertyName("retryConfiguration")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnFailureRetryConfiguration>? RetryConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnSuccessConditionRuleRuleTypeId
{
    /// <summary>A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are Approval, Build, Deploy, Invoke, Source and Test.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The creator of the action being called. Possible values are AWS, Custom and ThirdParty.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>The provider of the service being called by the action. Valid providers are determined by the action category. Provider names are listed in the Action Structure Reference documentation.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnSuccessConditionRule
{
    /// <summary>The shell commands to run with your commands rule in CodePipeline. All commands are supported except multi-line formats.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation. Note: The DetectChanges parameter  in the configuration section causes CodePipeline to automatically start your pipeline upon new commits. Please refer to AWS Documentation for more details: https://docs.aws.amazon.com/codepipeline/latest/userguide/action-reference-CodestarConnectionSource.html#action-reference-CodestarConnectionSource-config.</summary>
    [JsonPropertyName("configuration")]
    public IDictionary<string, string>? Configuration { get; set; }

    /// <summary>A list of artifact names to be worked on.</summary>
    [JsonPropertyName("inputArtifacts")]
    public IList<string>? InputArtifacts { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region in which to run the action.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The ID for the rule type, which is made up of the combined values for category, owner, provider, and version. Defined as an rule_type_id block below.</summary>
    [JsonPropertyName("ruleTypeId")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnSuccessConditionRuleRuleTypeId>? RuleTypeId { get; set; }

    /// <summary>The action timeout for the rule.</summary>
    [JsonPropertyName("timeoutInMinutes")]
    public double? TimeoutInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnSuccessCondition
{
    /// <summary>The conditions that are configured as failure conditions. Possible values are ROLLBACK,  FAIL, RETRY and SKIP.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>The rules that make up the condition. Defined as a rule block below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnSuccessConditionRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStageOnSuccess
{
    /// <summary>The conditions that are success conditions. Defined as a condition block below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnSuccessCondition>? Condition { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1CodepipelineStatusAtProviderStageAction>? Action { get; set; }

    /// <summary>The method to use when a stage allows entry. For example, configuring this field for conditions will allow entry to the stage when the conditions are met.</summary>
    [JsonPropertyName("beforeEntry")]
    public IList<V1beta1CodepipelineStatusAtProviderStageBeforeEntry>? BeforeEntry { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The method to use when a stage has not completed successfully. For example, configuring this field for rollback will roll back a failed stage automatically to the last successful pipeline execution in the stage.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnFailure>? OnFailure { get; set; }

    /// <summary>The method to use when a stage has succeeded. For example, configuring this field for conditions will allow the stage to succeed when the conditions are met.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1CodepipelineStatusAtProviderStageOnSuccess>? OnSuccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPullRequestBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPullRequestFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPullRequest
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPullRequestBranches>? Branches { get; set; }

    /// <summary>A list that specifies which pull request events to filter on (opened, updated, closed) for the trigger configuration. Possible values are OPEN, UPDATED  and CLOSED.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPullRequestFilePaths>? FilePaths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPushBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPushFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPushTags
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPush
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPushBranches>? Branches { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPushFilePaths>? FilePaths { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPushTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerGitConfiguration
{
    /// <summary>The field where the repository event that will start the pipeline is specified as pull requests. A pull_request block is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPullRequest>? PullRequest { get; set; }

    /// <summary>The field where the repository event that will start the pipeline, such as pushing Git tags, is specified with details. A push block is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerGitConfigurationPush>? Push { get; set; }

    /// <summary>The name of the pipeline source action where the trigger configuration, such as Git tags, is specified. The trigger configuration will start the pipeline upon the specified change only.</summary>
    [JsonPropertyName("sourceActionName")]
    public string? SourceActionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTrigger
{
    /// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
    [JsonPropertyName("gitConfiguration")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerGitConfiguration>? GitConfiguration { get; set; }

    /// <summary>The source provider for the event. Possible value is CodeStarSourceConnection.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequestBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequestFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequest
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequestBranches>? Branches { get; set; }

    /// <summary>A list that specifies which pull request events to filter on (opened, updated, closed) for the trigger configuration. Possible values are OPEN, UPDATED  and CLOSED.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequestFilePaths>? FilePaths { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPushBranches
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPushFilePaths
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPushTags
{
    /// <summary>A list of patterns of Git tags that, when pushed, are to be excluded from starting the pipeline.</summary>
    [JsonPropertyName("excludes")]
    public IList<string>? Excludes { get; set; }

    /// <summary>A list of patterns of Git tags that, when pushed, are to be included as criteria that starts the pipeline.</summary>
    [JsonPropertyName("includes")]
    public IList<string>? Includes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPush
{
    /// <summary>The field that specifies to filter on branches for the pull request trigger configuration. A branches block is documented below.</summary>
    [JsonPropertyName("branches")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPushBranches>? Branches { get; set; }

    /// <summary>The field that specifies to filter on file paths for the pull request trigger configuration. A file_paths block is documented below.</summary>
    [JsonPropertyName("filePaths")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPushFilePaths>? FilePaths { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPushTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAllGitConfiguration
{
    /// <summary>The field where the repository event that will start the pipeline is specified as pull requests. A pull_request block is documented below.</summary>
    [JsonPropertyName("pullRequest")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPullRequest>? PullRequest { get; set; }

    /// <summary>The field where the repository event that will start the pipeline, such as pushing Git tags, is specified with details. A push block is documented below.</summary>
    [JsonPropertyName("push")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAllGitConfigurationPush>? Push { get; set; }

    /// <summary>The name of the pipeline source action where the trigger configuration, such as Git tags, is specified. The trigger configuration will start the pipeline upon the specified change only.</summary>
    [JsonPropertyName("sourceActionName")]
    public string? SourceActionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderTriggerAll
{
    /// <summary>Provides the filter criteria and the source stage for the repository event that starts the pipeline. For more information, refer to the AWS documentation. A git_configuration block is documented below.</summary>
    [JsonPropertyName("gitConfiguration")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAllGitConfiguration>? GitConfiguration { get; set; }

    /// <summary>The source provider for the event. Possible value is CodeStarSourceConnection.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderVariable
{
    /// <summary>The default value of a pipeline-level variable.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The description of a pipeline-level variable.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of a pipeline-level variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProvider
{
    /// <summary>Codepipeline ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>One or more artifact_store blocks. Artifact stores are documented below.</summary>
    [JsonPropertyName("artifactStore")]
    public IList<V1beta1CodepipelineStatusAtProviderArtifactStore>? ArtifactStore { get; set; }

    /// <summary>The method that the pipeline will use to handle multiple executions. The default mode is SUPERSEDED. For value values, refer to the AWS documentation.</summary>
    [JsonPropertyName("executionMode")]
    public string? ExecutionMode { get; set; }

    /// <summary>Codepipeline ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of the pipeline. Possible values are: V1 and V2. Default value is V1.</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>(Minimum of at least two stage blocks is required) A stage block. Stages are documented below.</summary>
    [JsonPropertyName("stage")]
    public IList<V1beta1CodepipelineStatusAtProviderStage>? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A trigger block. Valid only when pipeline_type is V2. Triggers are documented below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1CodepipelineStatusAtProviderTrigger>? Trigger { get; set; }

    /// <summary>A list of all triggers present on the pipeline, including default triggers added by AWS for V2 pipelines which omit an explicit trigger definition.</summary>
    [JsonPropertyName("triggerAll")]
    public IList<V1beta1CodepipelineStatusAtProviderTriggerAll>? TriggerAll { get; set; }

    /// <summary>A pipeline-level variable block. Valid only when pipeline_type is V2. Variable are documented below.</summary>
    [JsonPropertyName("variable")]
    public IList<V1beta1CodepipelineStatusAtProviderVariable>? Variable { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusConditions
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

/// <summary>CodepipelineStatus defines the observed state of Codepipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CodepipelineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CodepipelineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Codepipeline is the Schema for the Codepipelines API. Provides a CodePipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Codepipeline : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CodepipelineSpec>, IStatus<V1beta1CodepipelineStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Codepipeline";
    public const string KubeGroup = "codepipeline.aws.upbound.io";
    public const string KubePluralName = "codepipelines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CodepipelineSpec defines the desired state of Codepipeline</summary>
    [JsonPropertyName("spec")]
    public V1beta1CodepipelineSpec Spec { get; set; }

    /// <summary>CodepipelineStatus defines the observed state of Codepipeline.</summary>
    [JsonPropertyName("status")]
    public V1beta1CodepipelineStatus? Status { get; set; }
}

/// <summary>Codepipeline is the Schema for the Codepipelines API. Provides a CodePipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CodepipelineList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Codepipeline>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CodepipelineList";
    public const string KubeGroup = "codepipeline.aws.upbound.io";
    public const string KubePluralName = "codepipelines";
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
    public IList<V1beta1Codepipeline> Items { get; set; }
}