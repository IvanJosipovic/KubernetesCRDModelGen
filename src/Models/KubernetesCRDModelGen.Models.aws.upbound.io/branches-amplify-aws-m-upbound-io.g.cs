using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.amplify.aws.m.upbound.io;
#nullable enable
/// <summary>Branch is the Schema for the Branchs API. Provides an Amplify Branch resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BranchList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Branch>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BranchList";
    public const string KubeGroup = "amplify.aws.m.upbound.io";
    public const string KubePluralName = "branches";
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
    public IList<V1beta1Branch> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecForProviderAppIdRefPolicy
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
/// <summary>Reference to a App in amplify to populate appId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecForProviderAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BranchSpecForProviderAppIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecForProviderAppIdSelectorPolicy
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
/// <summary>Selector for a App in amplify to populate appId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecForProviderAppIdSelector
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
    public V1beta1BranchSpecForProviderAppIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Basic authorization credentials for the branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecForProviderBasicAuthCredentialsSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecForProvider
{
    /// <summary>Unique ID for an Amplify app.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>Reference to a App in amplify to populate appId.</summary>
    [JsonPropertyName("appIdRef")]
    public V1beta1BranchSpecForProviderAppIdRef? AppIdRef { get; set; }

    /// <summary>Selector for a App in amplify to populate appId.</summary>
    [JsonPropertyName("appIdSelector")]
    public V1beta1BranchSpecForProviderAppIdSelector? AppIdSelector { get; set; }

    /// <summary>ARN for a backend environment that is part of an Amplify app.</summary>
    [JsonPropertyName("backendEnvironmentArn")]
    public string? BackendEnvironmentArn { get; set; }

    /// <summary>Basic authorization credentials for the branch.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta1BranchSpecForProviderBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>Description for the branch.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name for a branch. This is used as the default domain prefix.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Enables auto building for the branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables notifications for the branch.</summary>
    [JsonPropertyName("enableNotification")]
    public bool? EnableNotification { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for this branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Enables skew protection for the branch.</summary>
    [JsonPropertyName("enableSkewProtection")]
    public bool? EnableSkewProtection { get; set; }

    /// <summary>Environment variables for the branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Describes the current stage for the branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Content Time To Live (TTL) for the website in seconds.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Basic authorization credentials for the branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecInitProviderBasicAuthCredentialsSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecInitProvider
{
    /// <summary>ARN for a backend environment that is part of an Amplify app.</summary>
    [JsonPropertyName("backendEnvironmentArn")]
    public string? BackendEnvironmentArn { get; set; }

    /// <summary>Basic authorization credentials for the branch.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta1BranchSpecInitProviderBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>Description for the branch.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Display name for a branch. This is used as the default domain prefix.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Enables auto building for the branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables notifications for the branch.</summary>
    [JsonPropertyName("enableNotification")]
    public bool? EnableNotification { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for this branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Enables skew protection for the branch.</summary>
    [JsonPropertyName("enableSkewProtection")]
    public bool? EnableSkewProtection { get; set; }

    /// <summary>Environment variables for the branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Describes the current stage for the branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Content Time To Live (TTL) for the website in seconds.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpecProviderConfigRef
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
public partial class V1beta1BranchSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BranchSpec defines the desired state of Branch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BranchSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BranchSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BranchSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BranchSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchStatusAtProvider
{
    /// <summary>Unique ID for an Amplify app.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>ARN for the branch.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A list of custom resources that are linked to this branch.</summary>
    [JsonPropertyName("associatedResources")]
    public IList<string>? AssociatedResources { get; set; }

    /// <summary>ARN for a backend environment that is part of an Amplify app.</summary>
    [JsonPropertyName("backendEnvironmentArn")]
    public string? BackendEnvironmentArn { get; set; }

    /// <summary>Custom domains for the branch.</summary>
    [JsonPropertyName("customDomains")]
    public IList<string>? CustomDomains { get; set; }

    /// <summary>Description for the branch.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Destination branch if the branch is a pull request branch.</summary>
    [JsonPropertyName("destinationBranch")]
    public string? DestinationBranch { get; set; }

    /// <summary>Display name for a branch. This is used as the default domain prefix.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Enables auto building for the branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables notifications for the branch.</summary>
    [JsonPropertyName("enableNotification")]
    public bool? EnableNotification { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for this branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Enables skew protection for the branch.</summary>
    [JsonPropertyName("enableSkewProtection")]
    public bool? EnableSkewProtection { get; set; }

    /// <summary>Environment variables for the branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Source branch if the branch is a pull request branch.</summary>
    [JsonPropertyName("sourceBranch")]
    public string? SourceBranch { get; set; }

    /// <summary>Describes the current stage for the branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Content Time To Live (TTL) for the website in seconds.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchStatusConditions
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
/// <summary>BranchStatus defines the observed state of Branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BranchStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BranchStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BranchStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Branch is the Schema for the Branchs API. Provides an Amplify Branch resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Branch : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BranchSpec>, IStatus<V1beta1BranchStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Branch";
    public const string KubeGroup = "amplify.aws.m.upbound.io";
    public const string KubePluralName = "branches";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BranchSpec defines the desired state of Branch</summary>
    [JsonPropertyName("spec")]
    public V1beta1BranchSpec Spec { get; set; }

    /// <summary>BranchStatus defines the observed state of Branch.</summary>
    [JsonPropertyName("status")]
    public V1beta1BranchStatus? Status { get; set; }
}
#nullable disable
