using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingHttpBasicAuthPasswordSecretRef
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
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingHttpBasicAuth
{
    /// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingHttpBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username that's used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositoryHttpBasicAuthPasswordSecretRef
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
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositoryHttpBasicAuth
{
    /// <summary>The password used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositoryHttpBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username that's used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuthHostKeySecretRef
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

/// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuthPrivateKeySecretRef
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
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuthPrivateKeySecretRef PrivateKeySecretRef { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepository
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public IList<V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositoryHttpBasicAuth>? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>A name to identify on the Git repository, required only if repos exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An array of strings used to match an application name. For each pattern, use the {application}/{profile} format with wildcards.</summary>
    [JsonPropertyName("pattern")]
    public IList<string>? Pattern { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepositorySshAuth>? SshAuth { get; set; }

    /// <summary>The URI of the Git repository that's used as the Config Server back end should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuthHostKeySecretRef
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

/// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuthPrivateKeySecretRef
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
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>The host key of the Git repository server, should not include the algorithm prefix as covered by host-key-algorithm.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>The SSH private key to access the Git repository, required when the URI starts with git@ or ssh://.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuthPrivateKeySecretRef PrivateKeySecretRef { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderConfigServerGitSetting
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public IList<V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingHttpBasicAuth>? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingRepository>? Repository { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudServiceSpecForProviderConfigServerGitSettingSshAuth>? SshAuth { get; set; }

    /// <summary>The URI of the default Git repository used as the Config Server back end, should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Specifies the password of the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderContainerRegistryPasswordSecretRef
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
public partial class V1beta1SpringCloudServiceSpecForProviderContainerRegistry
{
    /// <summary>Specifies the name of the container registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the password of the container registry.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1SpringCloudServiceSpecForProviderContainerRegistryPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Specifies the login server of the container registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Specifies the username of the container registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderDefaultBuildService
{
    /// <summary>Specifies the name of the container registry used in the default build service.</summary>
    [JsonPropertyName("containerRegistryName")]
    public string? ContainerRegistryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderMarketplace
{
    /// <summary>Specifies the plan ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("plan")]
    public string? Plan { get; set; }

    /// <summary>Specifies the 3rd Party artifact that is being procured.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate appSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate appSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate serviceRuntimeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate serviceRuntimeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderNetwork
{
    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Apps. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appNetworkResourceGroup")]
    public string? AppNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet which should host the Spring Boot Applications deployed in this Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appSubnetId")]
    public string? AppSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate appSubnetId.</summary>
    [JsonPropertyName("appSubnetIdRef")]
    public V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdRef? AppSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate appSubnetId.</summary>
    [JsonPropertyName("appSubnetIdSelector")]
    public V1beta1SpringCloudServiceSpecForProviderNetworkAppSubnetIdSelector? AppSubnetIdSelector { get; set; }

    /// <summary>A list of (at least 3) CIDR ranges (at least /16) which are used to host the Spring Cloud infrastructure, which must not overlap with any existing CIDR ranges in the Subnet. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Specifies the egress traffic type of the Spring Cloud Service. Possible values are loadBalancer and userDefinedRouting. Defaults to loadBalancer. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>Ingress read time out in seconds.</summary>
    [JsonPropertyName("readTimeoutSeconds")]
    public double? ReadTimeoutSeconds { get; set; }

    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeNetworkResourceGroup")]
    public string? ServiceRuntimeNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet where the Service Runtime components of the Spring Cloud Service will exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeSubnetId")]
    public string? ServiceRuntimeSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate serviceRuntimeSubnetId.</summary>
    [JsonPropertyName("serviceRuntimeSubnetIdRef")]
    public V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdRef? ServiceRuntimeSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate serviceRuntimeSubnetId.</summary>
    [JsonPropertyName("serviceRuntimeSubnetIdSelector")]
    public V1beta1SpringCloudServiceSpecForProviderNetworkServiceRuntimeSubnetIdSelector? ServiceRuntimeSubnetIdSelector { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate connectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate connectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProviderTrace
{
    /// <summary>The connection string used for Application Insights.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate connectionString.</summary>
    [JsonPropertyName("connectionStringRef")]
    public V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringRef? ConnectionStringRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate connectionString.</summary>
    [JsonPropertyName("connectionStringSelector")]
    public V1beta1SpringCloudServiceSpecForProviderTraceConnectionStringSelector? ConnectionStringSelector { get; set; }

    /// <summary>The sampling rate of Application Insights Agent. Must be between 0.0 and 100.0. Defaults to 10.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecForProvider
{
    /// <summary>Specifies the size for this Spring Cloud Service's default build agent pool. Possible values are S1, S2, S3, S4 and S5. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("buildAgentPoolSize")]
    public string? BuildAgentPoolSize { get; set; }

    /// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
    [JsonPropertyName("configServerGitSetting")]
    public IList<V1beta1SpringCloudServiceSpecForProviderConfigServerGitSetting>? ConfigServerGitSetting { get; set; }

    /// <summary>One or more container_registry block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("containerRegistry")]
    public IList<V1beta1SpringCloudServiceSpecForProviderContainerRegistry>? ContainerRegistry { get; set; }

    /// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("defaultBuildService")]
    public IList<V1beta1SpringCloudServiceSpecForProviderDefaultBuildService>? DefaultBuildService { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should the log stream in vnet injection instance could be accessed from Internet?</summary>
    [JsonPropertyName("logStreamPublicEndpointEnabled")]
    public bool? LogStreamPublicEndpointEnabled { get; set; }

    /// <summary>The resource Id of the Managed Environment that the Spring Apps instance builds on. Can only be specified when sku_tier is set to StandardGen2.</summary>
    [JsonPropertyName("managedEnvironmentId")]
    public string? ManagedEnvironmentId { get; set; }

    /// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
    [JsonPropertyName("marketplace")]
    public IList<V1beta1SpringCloudServiceSpecForProviderMarketplace>? Marketplace { get; set; }

    /// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1SpringCloudServiceSpecForProviderNetwork>? Network { get; set; }

    /// <summary>Specifies The name of the resource group in which to create the Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SpringCloudServiceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SpringCloudServiceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Whether enable the default Service Registry. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("serviceRegistryEnabled")]
    public bool? ServiceRegistryEnabled { get; set; }

    /// <summary>Specifies the SKU Name for this Spring Cloud Service. Possible values are B0, S0 and E0. Defaults to S0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the SKU Tier for this Spring Cloud Service. Possible values are Basic, Enterprise, Standard and StandardGen2. The attribute is automatically computed from API response except when managed_environment_id is defined. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trace block as defined below.</summary>
    [JsonPropertyName("trace")]
    public IList<V1beta1SpringCloudServiceSpecForProviderTrace>? Trace { get; set; }

    /// <summary>Whether zone redundancy is enabled for this Spring Cloud Service. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingHttpBasicAuth
{
    /// <summary>The username that's used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositoryHttpBasicAuth
{
    /// <summary>The username that's used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositorySshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingRepository
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositoryHttpBasicAuth>? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>A name to identify on the Git repository, required only if repos exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An array of strings used to match an application name. For each pattern, use the {application}/{profile} format with wildcards.</summary>
    [JsonPropertyName("pattern")]
    public IList<string>? Pattern { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingRepositorySshAuth>? SshAuth { get; set; }

    /// <summary>The URI of the Git repository that's used as the Config Server back end should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingSshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSetting
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingHttpBasicAuth>? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingRepository>? Repository { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSettingSshAuth>? SshAuth { get; set; }

    /// <summary>The URI of the default Git repository used as the Config Server back end, should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderContainerRegistry
{
    /// <summary>Specifies the name of the container registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the login server of the container registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Specifies the username of the container registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderDefaultBuildService
{
    /// <summary>Specifies the name of the container registry used in the default build service.</summary>
    [JsonPropertyName("containerRegistryName")]
    public string? ContainerRegistryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderMarketplace
{
    /// <summary>Specifies the plan ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("plan")]
    public string? Plan { get; set; }

    /// <summary>Specifies the 3rd Party artifact that is being procured.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate appSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate appSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate serviceRuntimeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate serviceRuntimeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderNetwork
{
    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Apps. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appNetworkResourceGroup")]
    public string? AppNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet which should host the Spring Boot Applications deployed in this Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appSubnetId")]
    public string? AppSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate appSubnetId.</summary>
    [JsonPropertyName("appSubnetIdRef")]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdRef? AppSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate appSubnetId.</summary>
    [JsonPropertyName("appSubnetIdSelector")]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkAppSubnetIdSelector? AppSubnetIdSelector { get; set; }

    /// <summary>A list of (at least 3) CIDR ranges (at least /16) which are used to host the Spring Cloud infrastructure, which must not overlap with any existing CIDR ranges in the Subnet. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Specifies the egress traffic type of the Spring Cloud Service. Possible values are loadBalancer and userDefinedRouting. Defaults to loadBalancer. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>Ingress read time out in seconds.</summary>
    [JsonPropertyName("readTimeoutSeconds")]
    public double? ReadTimeoutSeconds { get; set; }

    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeNetworkResourceGroup")]
    public string? ServiceRuntimeNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet where the Service Runtime components of the Spring Cloud Service will exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeSubnetId")]
    public string? ServiceRuntimeSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate serviceRuntimeSubnetId.</summary>
    [JsonPropertyName("serviceRuntimeSubnetIdRef")]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdRef? ServiceRuntimeSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate serviceRuntimeSubnetId.</summary>
    [JsonPropertyName("serviceRuntimeSubnetIdSelector")]
    public V1beta1SpringCloudServiceSpecInitProviderNetworkServiceRuntimeSubnetIdSelector? ServiceRuntimeSubnetIdSelector { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate connectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate connectionString.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProviderTrace
{
    /// <summary>The connection string used for Application Insights.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate connectionString.</summary>
    [JsonPropertyName("connectionStringRef")]
    public V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringRef? ConnectionStringRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate connectionString.</summary>
    [JsonPropertyName("connectionStringSelector")]
    public V1beta1SpringCloudServiceSpecInitProviderTraceConnectionStringSelector? ConnectionStringSelector { get; set; }

    /// <summary>The sampling rate of Application Insights Agent. Must be between 0.0 and 100.0. Defaults to 10.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecInitProvider
{
    /// <summary>Specifies the size for this Spring Cloud Service's default build agent pool. Possible values are S1, S2, S3, S4 and S5. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("buildAgentPoolSize")]
    public string? BuildAgentPoolSize { get; set; }

    /// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
    [JsonPropertyName("configServerGitSetting")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderConfigServerGitSetting>? ConfigServerGitSetting { get; set; }

    /// <summary>One or more container_registry block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("containerRegistry")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderContainerRegistry>? ContainerRegistry { get; set; }

    /// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("defaultBuildService")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderDefaultBuildService>? DefaultBuildService { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should the log stream in vnet injection instance could be accessed from Internet?</summary>
    [JsonPropertyName("logStreamPublicEndpointEnabled")]
    public bool? LogStreamPublicEndpointEnabled { get; set; }

    /// <summary>The resource Id of the Managed Environment that the Spring Apps instance builds on. Can only be specified when sku_tier is set to StandardGen2.</summary>
    [JsonPropertyName("managedEnvironmentId")]
    public string? ManagedEnvironmentId { get; set; }

    /// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
    [JsonPropertyName("marketplace")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderMarketplace>? Marketplace { get; set; }

    /// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderNetwork>? Network { get; set; }

    /// <summary>Whether enable the default Service Registry. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("serviceRegistryEnabled")]
    public bool? ServiceRegistryEnabled { get; set; }

    /// <summary>Specifies the SKU Name for this Spring Cloud Service. Possible values are B0, S0 and E0. Defaults to S0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the SKU Tier for this Spring Cloud Service. Possible values are Basic, Enterprise, Standard and StandardGen2. The attribute is automatically computed from API response except when managed_environment_id is defined. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trace block as defined below.</summary>
    [JsonPropertyName("trace")]
    public IList<V1beta1SpringCloudServiceSpecInitProviderTrace>? Trace { get; set; }

    /// <summary>Whether zone redundancy is enabled for this Spring Cloud Service. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecManagementPoliciesEnum
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
public enum V1beta1SpringCloudServiceSpecProviderConfigRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
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
public enum V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1SpringCloudServiceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SpringCloudServiceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SpringCloudServiceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SpringCloudServiceSpec defines the desired state of SpringCloudService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpringCloudServiceSpecDeletionPolicyEnum>))]
    public V1beta1SpringCloudServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpringCloudServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SpringCloudServiceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingHttpBasicAuth
{
    /// <summary>The username that's used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingRepositoryHttpBasicAuth
{
    /// <summary>The username that's used to access the Git repository server, required when the Git repository server supports HTTP Basic Authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingRepositorySshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingRepository
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingRepositoryHttpBasicAuth>? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>A name to identify on the Git repository, required only if repos exists.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An array of strings used to match an application name. For each pattern, use the {application}/{profile} format with wildcards.</summary>
    [JsonPropertyName("pattern")]
    public IList<string>? Pattern { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingRepositorySshAuth>? SshAuth { get; set; }

    /// <summary>The URI of the Git repository that's used as the Config Server back end should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingSshAuth
{
    /// <summary>The host key algorithm, should be ssh-dss, ssh-rsa, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, or ecdsa-sha2-nistp521. Required only if host-key exists.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Indicates whether the Config Server instance will fail to start if the host_key does not match. Defaults to true.</summary>
    [JsonPropertyName("strictHostKeyCheckingEnabled")]
    public bool? StrictHostKeyCheckingEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSetting
{
    /// <summary>A http_basic_auth block as defined below.</summary>
    [JsonPropertyName("httpBasicAuth")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingHttpBasicAuth>? HttpBasicAuth { get; set; }

    /// <summary>The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>One or more repository blocks as defined below.</summary>
    [JsonPropertyName("repository")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingRepository>? Repository { get; set; }

    /// <summary>An array of strings used to search subdirectories of the Git repository.</summary>
    [JsonPropertyName("searchPaths")]
    public IList<string>? SearchPaths { get; set; }

    /// <summary>A ssh_auth block as defined below.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSettingSshAuth>? SshAuth { get; set; }

    /// <summary>The URI of the default Git repository used as the Config Server back end, should be started with http://, https://, git@, or ssh://.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderContainerRegistry
{
    /// <summary>Specifies the name of the container registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the login server of the container registry.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Specifies the username of the container registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderDefaultBuildService
{
    /// <summary>Specifies the name of the container registry used in the default build service.</summary>
    [JsonPropertyName("containerRegistryName")]
    public string? ContainerRegistryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderMarketplace
{
    /// <summary>Specifies the plan ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("plan")]
    public string? Plan { get; set; }

    /// <summary>Specifies the 3rd Party artifact that is being procured.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher ID of the 3rd Party Artifact that is being procured.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderNetwork
{
    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Apps. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appNetworkResourceGroup")]
    public string? AppNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet which should host the Spring Boot Applications deployed in this Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appSubnetId")]
    public string? AppSubnetId { get; set; }

    /// <summary>A list of (at least 3) CIDR ranges (at least /16) which are used to host the Spring Cloud infrastructure, which must not overlap with any existing CIDR ranges in the Subnet. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Specifies the egress traffic type of the Spring Cloud Service. Possible values are loadBalancer and userDefinedRouting. Defaults to loadBalancer. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>Ingress read time out in seconds.</summary>
    [JsonPropertyName("readTimeoutSeconds")]
    public double? ReadTimeoutSeconds { get; set; }

    /// <summary>Specifies the Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeNetworkResourceGroup")]
    public string? ServiceRuntimeNetworkResourceGroup { get; set; }

    /// <summary>Specifies the ID of the Subnet where the Service Runtime components of the Spring Cloud Service will exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceRuntimeSubnetId")]
    public string? ServiceRuntimeSubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderRequiredNetworkTrafficRules
{
    /// <summary>The direction of required traffic. Possible values are Inbound, Outbound.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The FQDN list of required traffic.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>The IP list of required traffic.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The port of required traffic.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol of required traffic.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProviderTrace
{
    /// <summary>The connection string used for Application Insights.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>The sampling rate of Application Insights Agent. Must be between 0.0 and 100.0. Defaults to 10.0.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusAtProvider
{
    /// <summary>Specifies the size for this Spring Cloud Service's default build agent pool. Possible values are S1, S2, S3, S4 and S5. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("buildAgentPoolSize")]
    public string? BuildAgentPoolSize { get; set; }

    /// <summary>A config_server_git_setting block as defined below. This field is applicable only for Spring Cloud Service with basic and standard tier.</summary>
    [JsonPropertyName("configServerGitSetting")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderConfigServerGitSetting>? ConfigServerGitSetting { get; set; }

    /// <summary>One or more container_registry block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("containerRegistry")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderContainerRegistry>? ContainerRegistry { get; set; }

    /// <summary>A default_build_service block as defined below. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("defaultBuildService")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderDefaultBuildService>? DefaultBuildService { get; set; }

    /// <summary>The ID of the Spring Cloud Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Should the log stream in vnet injection instance could be accessed from Internet?</summary>
    [JsonPropertyName("logStreamPublicEndpointEnabled")]
    public bool? LogStreamPublicEndpointEnabled { get; set; }

    /// <summary>The resource Id of the Managed Environment that the Spring Apps instance builds on. Can only be specified when sku_tier is set to StandardGen2.</summary>
    [JsonPropertyName("managedEnvironmentId")]
    public string? ManagedEnvironmentId { get; set; }

    /// <summary>A marketplace block as defined below. Can only be specified when sku is set to E0.</summary>
    [JsonPropertyName("marketplace")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderMarketplace>? Marketplace { get; set; }

    /// <summary>A network block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderNetwork>? Network { get; set; }

    /// <summary>A list of the outbound Public IP Addresses used by this Spring Cloud Service.</summary>
    [JsonPropertyName("outboundPublicIpAddresses")]
    public IList<string>? OutboundPublicIpAddresses { get; set; }

    /// <summary>A list of required_network_traffic_rules blocks as defined below.</summary>
    [JsonPropertyName("requiredNetworkTrafficRules")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderRequiredNetworkTrafficRules>? RequiredNetworkTrafficRules { get; set; }

    /// <summary>Specifies The name of the resource group in which to create the Spring Cloud Service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Whether enable the default Service Registry. This field is applicable only for Spring Cloud Service with enterprise tier.</summary>
    [JsonPropertyName("serviceRegistryEnabled")]
    public bool? ServiceRegistryEnabled { get; set; }

    /// <summary>The ID of the Spring Cloud Service Registry.</summary>
    [JsonPropertyName("serviceRegistryId")]
    public string? ServiceRegistryId { get; set; }

    /// <summary>Specifies the SKU Name for this Spring Cloud Service. Possible values are B0, S0 and E0. Defaults to S0. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the SKU Tier for this Spring Cloud Service. Possible values are Basic, Enterprise, Standard and StandardGen2. The attribute is automatically computed from API response except when managed_environment_id is defined. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A trace block as defined below.</summary>
    [JsonPropertyName("trace")]
    public IList<V1beta1SpringCloudServiceStatusAtProviderTrace>? Trace { get; set; }

    /// <summary>Whether zone redundancy is enabled for this Spring Cloud Service. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatusConditions
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

/// <summary>SpringCloudServiceStatus defines the observed state of SpringCloudService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudService is the Schema for the SpringCloudServices API. Manages an Azure Spring Cloud Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudServiceSpec>, IStatus<V1beta1SpringCloudServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudService";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudServiceSpec defines the desired state of SpringCloudService</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudServiceSpec Spec { get; set; }

    /// <summary>SpringCloudServiceStatus defines the observed state of SpringCloudService.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudServiceStatus? Status { get; set; }
}