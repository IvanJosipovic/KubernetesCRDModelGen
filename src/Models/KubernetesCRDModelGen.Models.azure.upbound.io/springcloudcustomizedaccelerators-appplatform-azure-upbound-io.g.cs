using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
/// <summary>Specifies the password of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositoryBasicAuthPasswordSecretRef
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
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositoryBasicAuth
{
    /// <summary>Specifies the password of git repository basic auth.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositoryBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Specifies the Public SSH Key of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuthHostKeySecretRef
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

/// <summary>Specifies the Private SSH Key of git repository basic auth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuthPrivateKeySecretRef
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
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuth
{
    /// <summary>Specifies the SSH Key algorithm of git repository basic auth.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }

    /// <summary>Specifies the Public SSH Key of git repository basic auth.</summary>
    [JsonPropertyName("hostKeySecretRef")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuthHostKeySecretRef? HostKeySecretRef { get; set; }

    /// <summary>Specifies the Private SSH Key of git repository basic auth.</summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuthPrivateKeySecretRef PrivateKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepository
{
    /// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositoryBasicAuth>? BasicAuth { get; set; }

    /// <summary>Specifies the Git repository branch to be used.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Specifies the ID of the CA Spring Cloud Certificate for https URL of Git repository.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the Git repository commit to be used.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Specifies the Git repository tag to be used.</summary>
    [JsonPropertyName("gitTag")]
    public string? GitTag { get; set; }

    /// <summary>Specifies the interval for checking for updates to Git or image repository. It should be greater than 10.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path under the git repository to be treated as the root directory of the accelerator or the fragment (depending on accelerator_type).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepositorySshAuth>? SshAuth { get; set; }

    /// <summary>Specifies Git repository URL for the accelerator.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudAccelerator in appplatform to populate springCloudAcceleratorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudAccelerator in appplatform to populate springCloudAcceleratorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecForProvider
{
    /// <summary>Specifies a list of accelerator tags.</summary>
    [JsonPropertyName("acceleratorTags")]
    public IList<string>? AcceleratorTags { get; set; }

    /// <summary>Specifies the type of the Spring Cloud Customized Accelerator. Possible values are Accelerator and Fragment. Defaults to Accelerator.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Specifies the description of the Spring Cloud Customized Accelerator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A git_repository block as defined below.</summary>
    [JsonPropertyName("gitRepository")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorSpecForProviderGitRepository>? GitRepository { get; set; }

    /// <summary>Specifies the icon URL of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    /// <summary>The ID of the Spring Cloud Accelerator. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("springCloudAcceleratorId")]
    public string? SpringCloudAcceleratorId { get; set; }

    /// <summary>Reference to a SpringCloudAccelerator in appplatform to populate springCloudAcceleratorId.</summary>
    [JsonPropertyName("springCloudAcceleratorIdRef")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdRef? SpringCloudAcceleratorIdRef { get; set; }

    /// <summary>Selector for a SpringCloudAccelerator in appplatform to populate springCloudAcceleratorId.</summary>
    [JsonPropertyName("springCloudAcceleratorIdSelector")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecForProviderSpringCloudAcceleratorIdSelector? SpringCloudAcceleratorIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositoryBasicAuth
{
    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositorySshAuth
{
    /// <summary>Specifies the SSH Key algorithm of git repository basic auth.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecInitProviderGitRepository
{
    /// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositoryBasicAuth>? BasicAuth { get; set; }

    /// <summary>Specifies the Git repository branch to be used.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Specifies the ID of the CA Spring Cloud Certificate for https URL of Git repository.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the Git repository commit to be used.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Specifies the Git repository tag to be used.</summary>
    [JsonPropertyName("gitTag")]
    public string? GitTag { get; set; }

    /// <summary>Specifies the interval for checking for updates to Git or image repository. It should be greater than 10.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path under the git repository to be treated as the root directory of the accelerator or the fragment (depending on accelerator_type).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorSpecInitProviderGitRepositorySshAuth>? SshAuth { get; set; }

    /// <summary>Specifies Git repository URL for the accelerator.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecInitProvider
{
    /// <summary>Specifies a list of accelerator tags.</summary>
    [JsonPropertyName("acceleratorTags")]
    public IList<string>? AcceleratorTags { get; set; }

    /// <summary>Specifies the type of the Spring Cloud Customized Accelerator. Possible values are Accelerator and Fragment. Defaults to Accelerator.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Specifies the description of the Spring Cloud Customized Accelerator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A git_repository block as defined below.</summary>
    [JsonPropertyName("gitRepository")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorSpecInitProviderGitRepository>? GitRepository { get; set; }

    /// <summary>Specifies the icon URL of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicy
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
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SpringCloudCustomizedAcceleratorSpec defines the desired state of SpringCloudCustomizedAccelerator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudCustomizedAcceleratorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorStatusAtProviderGitRepositoryBasicAuth
{
    /// <summary>Specifies the username of git repository basic auth.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorStatusAtProviderGitRepositorySshAuth
{
    /// <summary>Specifies the SSH Key algorithm of git repository basic auth.</summary>
    [JsonPropertyName("hostKeyAlgorithm")]
    public string? HostKeyAlgorithm { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorStatusAtProviderGitRepository
{
    /// <summary>A basic_auth block as defined below. Conflicts with git_repository[0].ssh_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorStatusAtProviderGitRepositoryBasicAuth>? BasicAuth { get; set; }

    /// <summary>Specifies the Git repository branch to be used.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>Specifies the ID of the CA Spring Cloud Certificate for https URL of Git repository.</summary>
    [JsonPropertyName("caCertificateId")]
    public string? CaCertificateId { get; set; }

    /// <summary>Specifies the Git repository commit to be used.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    /// <summary>Specifies the Git repository tag to be used.</summary>
    [JsonPropertyName("gitTag")]
    public string? GitTag { get; set; }

    /// <summary>Specifies the interval for checking for updates to Git or image repository. It should be greater than 10.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path under the git repository to be treated as the root directory of the accelerator or the fragment (depending on accelerator_type).</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A ssh_auth block as defined below. Conflicts with git_repository[0].basic_auth. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("sshAuth")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorStatusAtProviderGitRepositorySshAuth>? SshAuth { get; set; }

    /// <summary>Specifies Git repository URL for the accelerator.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorStatusAtProvider
{
    /// <summary>Specifies a list of accelerator tags.</summary>
    [JsonPropertyName("acceleratorTags")]
    public IList<string>? AcceleratorTags { get; set; }

    /// <summary>Specifies the type of the Spring Cloud Customized Accelerator. Possible values are Accelerator and Fragment. Defaults to Accelerator.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Specifies the description of the Spring Cloud Customized Accelerator.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>A git_repository block as defined below.</summary>
    [JsonPropertyName("gitRepository")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorStatusAtProviderGitRepository>? GitRepository { get; set; }

    /// <summary>Specifies the icon URL of the Spring Cloud Customized Accelerator..</summary>
    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    /// <summary>The ID of the Spring Cloud Customized Accelerator.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Spring Cloud Accelerator. Changing this forces a new Spring Cloud Customized Accelerator to be created.</summary>
    [JsonPropertyName("springCloudAcceleratorId")]
    public string? SpringCloudAcceleratorId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorStatusConditions
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

/// <summary>SpringCloudCustomizedAcceleratorStatus defines the observed state of SpringCloudCustomizedAccelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudCustomizedAcceleratorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudCustomizedAcceleratorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudCustomizedAcceleratorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudCustomizedAccelerator is the Schema for the SpringCloudCustomizedAccelerators API. Manages a Spring Cloud Customized Accelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudCustomizedAccelerator : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudCustomizedAcceleratorSpec>, IStatus<V1beta1SpringCloudCustomizedAcceleratorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudCustomizedAccelerator";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudcustomizedaccelerators";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudCustomizedAcceleratorSpec defines the desired state of SpringCloudCustomizedAccelerator</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudCustomizedAcceleratorSpec Spec { get; set; }

    /// <summary>SpringCloudCustomizedAcceleratorStatus defines the observed state of SpringCloudCustomizedAccelerator.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudCustomizedAcceleratorStatus? Status { get; set; }
}

/// <summary>SpringCloudCustomizedAccelerator is the Schema for the SpringCloudCustomizedAccelerators API. Manages a Spring Cloud Customized Accelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudCustomizedAcceleratorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpringCloudCustomizedAccelerator>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudCustomizedAcceleratorList";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudcustomizedaccelerators";
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
    public IList<V1beta1SpringCloudCustomizedAccelerator> Items { get; set; }
}