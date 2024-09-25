using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codepipeline.aws.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecForProviderArtifactStoreLocationRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecForProviderArtifactStoreLocationSelectorPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecForProviderRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecForProviderRoleArnRefPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecForProviderRoleArnRefPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecForProviderRoleArnRefPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation.</summary>
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

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecForProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1CodepipelineSpecForProviderStageAction>? Action { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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

    /// <summary>The name of the pipeline source action where the trigger configuration.</summary>
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

    /// <summary>The region in which to run the action. Region is the region you'd like your resource to be created in.</summary>
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecInitProviderArtifactStoreLocationRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecInitProviderArtifactStoreLocationSelectorPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecInitProviderRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecInitProviderRoleArnRefPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecInitProviderRoleArnRefPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation.</summary>
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

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecInitProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1CodepipelineSpecInitProviderStageAction>? Action { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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

    /// <summary>The name of the pipeline source action where the trigger configuration.</summary>
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

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1CodepipelineSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CodepipelineSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CodepipelineSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
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
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodepipelineSpecDeletionPolicyEnum>))]
    public V1beta1CodepipelineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CodepipelineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CodepipelineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CodepipelineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CodepipelineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CodepipelineSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
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

    /// <summary>A map of the action declaration's configuration. Configurations options for action types and providers can be found in the Pipeline Structure Reference and Action Structure Reference documentation.</summary>
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

    /// <summary>A string that identifies the action type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CodepipelineStatusAtProviderStage
{
    /// <summary>The action(s) to include in the stage. Defined as an action block below</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1CodepipelineStatusAtProviderStageAction>? Action { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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

    /// <summary>The name of the pipeline source action where the trigger configuration.</summary>
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
    /// <summary>The codepipeline ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>One or more artifact_store blocks. Artifact stores are documented below.</summary>
    [JsonPropertyName("artifactStore")]
    public IList<V1beta1CodepipelineStatusAtProviderArtifactStore>? ArtifactStore { get; set; }

    /// <summary>The method that the pipeline will use to handle multiple executions. The default mode is SUPERSEDED. For value values, refer to the AWS documentation.</summary>
    [JsonPropertyName("executionMode")]
    public string? ExecutionMode { get; set; }

    /// <summary>The codepipeline ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of the pipeline. Possible values are: V1 and V2. Default value is V1.</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

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