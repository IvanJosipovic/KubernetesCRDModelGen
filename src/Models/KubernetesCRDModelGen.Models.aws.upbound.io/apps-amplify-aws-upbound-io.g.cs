using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.amplify.aws.upbound.io;
/// <summary>App is the Schema for the Apps API. Provides an Amplify App resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AppList : IKubernetesObject<V1ListMeta>, IItems<V1beta1App>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppList";
    public const string KubeGroup = "amplify.aws.upbound.io";
    public const string KubePluralName = "apps";
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
    public IList<V1beta1App> Items { get; set; }
}

/// <summary>Personal access token for a third-party source control system for an Amplify app. This token must have write access to the relevant repo to create a webhook and a read-only deploy key for the Amplify project. The token is not stored, so after applying this attribute can be removed and the setup token deleted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderAccessTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Basic authorization credentials for the autocreated branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderAutoBranchCreationConfigBasicAuthCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderAutoBranchCreationConfig
{
    /// <summary>Basic authorization credentials for the autocreated branch.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta1AppSpecForProviderAutoBranchCreationConfigBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>Build specification (build spec) for the autocreated branch.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Enables auto building for the autocreated branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the autocreated branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for the autocreated branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Environment variables for the autocreated branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the autocreated branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Describes the current stage for the autocreated branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

/// <summary>Credentials for basic authorization for an Amplify app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderBasicAuthCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderCacheConfig
{
    /// <summary>Type of cache configuration to use for an Amplify app. Valid values: AMPLIFY_MANAGED, AMPLIFY_MANAGED_NO_COOKIES.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderComputeRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate computeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderComputeRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecForProviderComputeRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderComputeRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate computeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderComputeRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecForProviderComputeRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderCustomRule
{
    /// <summary>Condition for a URL rewrite or redirect rule, such as a country code.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Source pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Status code for a URL rewrite or redirect rule. Valid values: 200, 301, 302, 404, 404-200.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderIamServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamServiceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderIamServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecForProviderIamServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderIamServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamServiceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderIamServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecForProviderIamServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderJobConfig
{
    /// <summary>Size of the build instance. Valid values: STANDARD_8GB, LARGE_16GB, and XLARGE_72GB. Default: STANDARD_8GB.</summary>
    [JsonPropertyName("buildComputeType")]
    public string? BuildComputeType { get; set; }
}

/// <summary>OAuth token for a third-party source control system for an Amplify app. The OAuth token is used to create a webhook and a read-only deploy key. The OAuth token is not stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProviderOauthTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecForProvider
{
    /// <summary>Personal access token for a third-party source control system for an Amplify app. This token must have write access to the relevant repo to create a webhook and a read-only deploy key for the Amplify project. The token is not stored, so after applying this attribute can be removed and the setup token deleted.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta1AppSpecForProviderAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
    [JsonPropertyName("autoBranchCreationConfig")]
    public IList<V1beta1AppSpecForProviderAutoBranchCreationConfig>? AutoBranchCreationConfig { get; set; }

    /// <summary>Automated branch creation glob patterns for an Amplify app.</summary>
    [JsonPropertyName("autoBranchCreationPatterns")]
    public IList<string>? AutoBranchCreationPatterns { get; set; }

    /// <summary>Credentials for basic authorization for an Amplify app.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta1AppSpecForProviderBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>The build specification (build spec) for an Amplify app.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
    [JsonPropertyName("cacheConfig")]
    public IList<V1beta1AppSpecForProviderCacheConfig>? CacheConfig { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) SSR compute role for an Amplify app.</summary>
    [JsonPropertyName("computeRoleArn")]
    public string? ComputeRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate computeRoleArn.</summary>
    [JsonPropertyName("computeRoleArnRef")]
    public V1beta1AppSpecForProviderComputeRoleArnRef? ComputeRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate computeRoleArn.</summary>
    [JsonPropertyName("computeRoleArnSelector")]
    public V1beta1AppSpecForProviderComputeRoleArnSelector? ComputeRoleArnSelector { get; set; }

    /// <summary>The custom HTTP headers for an Amplify app.</summary>
    [JsonPropertyName("customHeaders")]
    public string? CustomHeaders { get; set; }

    /// <summary>Custom rewrite and redirect rules for an Amplify app. See custom_rule Block for details.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta1AppSpecForProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Description for an Amplify app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enables automated branch creation for an Amplify app.</summary>
    [JsonPropertyName("enableAutoBranchCreation")]
    public bool? EnableAutoBranchCreation { get; set; }

    /// <summary>Enables basic authorization for an Amplify app. This will apply to all branches that are part of this app.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables auto-building of branches for the Amplify App.</summary>
    [JsonPropertyName("enableBranchAutoBuild")]
    public bool? EnableBranchAutoBuild { get; set; }

    /// <summary>Automatically disconnects a branch in the Amplify Console when you delete a branch from your Git repository.</summary>
    [JsonPropertyName("enableBranchAutoDeletion")]
    public bool? EnableBranchAutoDeletion { get; set; }

    /// <summary>Environment variables map for an Amplify app.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) service role for an Amplify app.</summary>
    [JsonPropertyName("iamServiceRoleArn")]
    public string? IamServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamServiceRoleArn.</summary>
    [JsonPropertyName("iamServiceRoleArnRef")]
    public V1beta1AppSpecForProviderIamServiceRoleArnRef? IamServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamServiceRoleArn.</summary>
    [JsonPropertyName("iamServiceRoleArnSelector")]
    public V1beta1AppSpecForProviderIamServiceRoleArnSelector? IamServiceRoleArnSelector { get; set; }

    /// <summary>Used to configure the Amplify Application build settings. See job_config Block for details.</summary>
    [JsonPropertyName("jobConfig")]
    public IList<V1beta1AppSpecForProviderJobConfig>? JobConfig { get; set; }

    /// <summary>Name for an Amplify app.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OAuth token for a third-party source control system for an Amplify app. The OAuth token is used to create a webhook and a read-only deploy key. The OAuth token is not stored.</summary>
    [JsonPropertyName("oauthTokenSecretRef")]
    public V1beta1AppSpecForProviderOauthTokenSecretRef? OauthTokenSecretRef { get; set; }

    /// <summary>Platform or framework for an Amplify app. Valid values: WEB, WEB_COMPUTE. Default value: WEB.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Repository for an Amplify app.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Personal access token for a third-party source control system for an Amplify app. This token must have write access to the relevant repo to create a webhook and a read-only deploy key for the Amplify project. The token is not stored, so after applying this attribute can be removed and the setup token deleted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderAccessTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Basic authorization credentials for the autocreated branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderAutoBranchCreationConfigBasicAuthCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderAutoBranchCreationConfig
{
    /// <summary>Basic authorization credentials for the autocreated branch.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta1AppSpecInitProviderAutoBranchCreationConfigBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>Build specification (build spec) for the autocreated branch.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Enables auto building for the autocreated branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the autocreated branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for the autocreated branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Environment variables for the autocreated branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the autocreated branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Describes the current stage for the autocreated branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

/// <summary>Credentials for basic authorization for an Amplify app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderBasicAuthCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderCacheConfig
{
    /// <summary>Type of cache configuration to use for an Amplify app. Valid values: AMPLIFY_MANAGED, AMPLIFY_MANAGED_NO_COOKIES.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderComputeRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate computeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderComputeRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecInitProviderComputeRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderComputeRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate computeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderComputeRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecInitProviderComputeRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderCustomRule
{
    /// <summary>Condition for a URL rewrite or redirect rule, such as a country code.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Source pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Status code for a URL rewrite or redirect rule. Valid values: 200, 301, 302, 404, 404-200.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderIamServiceRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamServiceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderIamServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecInitProviderIamServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderIamServiceRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamServiceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderIamServiceRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecInitProviderIamServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderJobConfig
{
    /// <summary>Size of the build instance. Valid values: STANDARD_8GB, LARGE_16GB, and XLARGE_72GB. Default: STANDARD_8GB.</summary>
    [JsonPropertyName("buildComputeType")]
    public string? BuildComputeType { get; set; }
}

/// <summary>OAuth token for a third-party source control system for an Amplify app. The OAuth token is used to create a webhook and a read-only deploy key. The OAuth token is not stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProviderOauthTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecInitProvider
{
    /// <summary>Personal access token for a third-party source control system for an Amplify app. This token must have write access to the relevant repo to create a webhook and a read-only deploy key for the Amplify project. The token is not stored, so after applying this attribute can be removed and the setup token deleted.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta1AppSpecInitProviderAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
    [JsonPropertyName("autoBranchCreationConfig")]
    public IList<V1beta1AppSpecInitProviderAutoBranchCreationConfig>? AutoBranchCreationConfig { get; set; }

    /// <summary>Automated branch creation glob patterns for an Amplify app.</summary>
    [JsonPropertyName("autoBranchCreationPatterns")]
    public IList<string>? AutoBranchCreationPatterns { get; set; }

    /// <summary>Credentials for basic authorization for an Amplify app.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta1AppSpecInitProviderBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>The build specification (build spec) for an Amplify app.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
    [JsonPropertyName("cacheConfig")]
    public IList<V1beta1AppSpecInitProviderCacheConfig>? CacheConfig { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) SSR compute role for an Amplify app.</summary>
    [JsonPropertyName("computeRoleArn")]
    public string? ComputeRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate computeRoleArn.</summary>
    [JsonPropertyName("computeRoleArnRef")]
    public V1beta1AppSpecInitProviderComputeRoleArnRef? ComputeRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate computeRoleArn.</summary>
    [JsonPropertyName("computeRoleArnSelector")]
    public V1beta1AppSpecInitProviderComputeRoleArnSelector? ComputeRoleArnSelector { get; set; }

    /// <summary>The custom HTTP headers for an Amplify app.</summary>
    [JsonPropertyName("customHeaders")]
    public string? CustomHeaders { get; set; }

    /// <summary>Custom rewrite and redirect rules for an Amplify app. See custom_rule Block for details.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta1AppSpecInitProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Description for an Amplify app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enables automated branch creation for an Amplify app.</summary>
    [JsonPropertyName("enableAutoBranchCreation")]
    public bool? EnableAutoBranchCreation { get; set; }

    /// <summary>Enables basic authorization for an Amplify app. This will apply to all branches that are part of this app.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables auto-building of branches for the Amplify App.</summary>
    [JsonPropertyName("enableBranchAutoBuild")]
    public bool? EnableBranchAutoBuild { get; set; }

    /// <summary>Automatically disconnects a branch in the Amplify Console when you delete a branch from your Git repository.</summary>
    [JsonPropertyName("enableBranchAutoDeletion")]
    public bool? EnableBranchAutoDeletion { get; set; }

    /// <summary>Environment variables map for an Amplify app.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) service role for an Amplify app.</summary>
    [JsonPropertyName("iamServiceRoleArn")]
    public string? IamServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamServiceRoleArn.</summary>
    [JsonPropertyName("iamServiceRoleArnRef")]
    public V1beta1AppSpecInitProviderIamServiceRoleArnRef? IamServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamServiceRoleArn.</summary>
    [JsonPropertyName("iamServiceRoleArnSelector")]
    public V1beta1AppSpecInitProviderIamServiceRoleArnSelector? IamServiceRoleArnSelector { get; set; }

    /// <summary>Used to configure the Amplify Application build settings. See job_config Block for details.</summary>
    [JsonPropertyName("jobConfig")]
    public IList<V1beta1AppSpecInitProviderJobConfig>? JobConfig { get; set; }

    /// <summary>Name for an Amplify app.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OAuth token for a third-party source control system for an Amplify app. The OAuth token is used to create a webhook and a read-only deploy key. The OAuth token is not stored.</summary>
    [JsonPropertyName("oauthTokenSecretRef")]
    public V1beta1AppSpecInitProviderOauthTokenSecretRef? OauthTokenSecretRef { get; set; }

    /// <summary>Platform or framework for an Amplify app. Valid values: WEB, WEB_COMPUTE. Default value: WEB.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Repository for an Amplify app.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecProviderConfigRefPolicy
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
public partial class V1beta1AppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AppSpec defines the desired state of App</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AppSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AppSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderAutoBranchCreationConfig
{
    /// <summary>Build specification (build spec) for the autocreated branch.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Enables auto building for the autocreated branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the autocreated branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for the autocreated branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Environment variables for the autocreated branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the autocreated branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Describes the current stage for the autocreated branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderCacheConfig
{
    /// <summary>Type of cache configuration to use for an Amplify app. Valid values: AMPLIFY_MANAGED, AMPLIFY_MANAGED_NO_COOKIES.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderCustomRule
{
    /// <summary>Condition for a URL rewrite or redirect rule, such as a country code.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Source pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Status code for a URL rewrite or redirect rule. Valid values: 200, 301, 302, 404, 404-200.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderJobConfig
{
    /// <summary>Size of the build instance. Valid values: STANDARD_8GB, LARGE_16GB, and XLARGE_72GB. Default: STANDARD_8GB.</summary>
    [JsonPropertyName("buildComputeType")]
    public string? BuildComputeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProviderProductionBranch
{
    /// <summary>Branch name for the production branch.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Last deploy time of the production branch.</summary>
    [JsonPropertyName("lastDeployTime")]
    public string? LastDeployTime { get; set; }

    /// <summary>Status of the production branch.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Thumbnail URL for the production branch.</summary>
    [JsonPropertyName("thumbnailUrl")]
    public string? ThumbnailUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusAtProvider
{
    /// <summary>ARN of the Amplify app.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
    [JsonPropertyName("autoBranchCreationConfig")]
    public IList<V1beta1AppStatusAtProviderAutoBranchCreationConfig>? AutoBranchCreationConfig { get; set; }

    /// <summary>Automated branch creation glob patterns for an Amplify app.</summary>
    [JsonPropertyName("autoBranchCreationPatterns")]
    public IList<string>? AutoBranchCreationPatterns { get; set; }

    /// <summary>The build specification (build spec) for an Amplify app.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
    [JsonPropertyName("cacheConfig")]
    public IList<V1beta1AppStatusAtProviderCacheConfig>? CacheConfig { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) SSR compute role for an Amplify app.</summary>
    [JsonPropertyName("computeRoleArn")]
    public string? ComputeRoleArn { get; set; }

    /// <summary>The custom HTTP headers for an Amplify app.</summary>
    [JsonPropertyName("customHeaders")]
    public string? CustomHeaders { get; set; }

    /// <summary>Custom rewrite and redirect rules for an Amplify app. See custom_rule Block for details.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta1AppStatusAtProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Default domain for the Amplify app.</summary>
    [JsonPropertyName("defaultDomain")]
    public string? DefaultDomain { get; set; }

    /// <summary>Description for an Amplify app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enables automated branch creation for an Amplify app.</summary>
    [JsonPropertyName("enableAutoBranchCreation")]
    public bool? EnableAutoBranchCreation { get; set; }

    /// <summary>Enables basic authorization for an Amplify app. This will apply to all branches that are part of this app.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables auto-building of branches for the Amplify App.</summary>
    [JsonPropertyName("enableBranchAutoBuild")]
    public bool? EnableBranchAutoBuild { get; set; }

    /// <summary>Automatically disconnects a branch in the Amplify Console when you delete a branch from your Git repository.</summary>
    [JsonPropertyName("enableBranchAutoDeletion")]
    public bool? EnableBranchAutoDeletion { get; set; }

    /// <summary>Environment variables map for an Amplify app.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) service role for an Amplify app.</summary>
    [JsonPropertyName("iamServiceRoleArn")]
    public string? IamServiceRoleArn { get; set; }

    /// <summary>Unique ID of the Amplify app.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Used to configure the Amplify Application build settings. See job_config Block for details.</summary>
    [JsonPropertyName("jobConfig")]
    public IList<V1beta1AppStatusAtProviderJobConfig>? JobConfig { get; set; }

    /// <summary>Name for an Amplify app.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Platform or framework for an Amplify app. Valid values: WEB, WEB_COMPUTE. Default value: WEB.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Describes the information about a production branch for an Amplify app. A production_branch block is documented below.</summary>
    [JsonPropertyName("productionBranch")]
    public IList<V1beta1AppStatusAtProviderProductionBranch>? ProductionBranch { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Repository for an Amplify app.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatusConditions
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

/// <summary>AppStatus defines the observed state of App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AppStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AppStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>App is the Schema for the Apps API. Provides an Amplify App resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1App : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AppSpec>, IStatus<V1beta1AppStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "App";
    public const string KubeGroup = "amplify.aws.upbound.io";
    public const string KubePluralName = "apps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppSpec defines the desired state of App</summary>
    [JsonPropertyName("spec")]
    public V1beta1AppSpec Spec { get; set; }

    /// <summary>AppStatus defines the observed state of App.</summary>
    [JsonPropertyName("status")]
    public V1beta1AppStatus? Status { get; set; }
}