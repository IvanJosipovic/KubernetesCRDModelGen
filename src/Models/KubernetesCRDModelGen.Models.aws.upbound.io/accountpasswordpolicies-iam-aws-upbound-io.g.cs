using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicySpecForProvider
{
    /// <summary>Whether to allow users to change their own password</summary>
    [JsonPropertyName("allowUsersToChangePassword")]
    public bool? AllowUsersToChangePassword { get; set; }

    /// <summary>Whether users are prevented from setting a new password after their password has expired (i.e., require administrator reset)</summary>
    [JsonPropertyName("hardExpiry")]
    public bool? HardExpiry { get; set; }

    /// <summary>The number of days that an user password is valid.</summary>
    [JsonPropertyName("maxPasswordAge")]
    public double? MaxPasswordAge { get; set; }

    /// <summary>Minimum length to require for user passwords.</summary>
    [JsonPropertyName("minimumPasswordLength")]
    public double? MinimumPasswordLength { get; set; }

    /// <summary>The number of previous passwords that users are prevented from reusing.</summary>
    [JsonPropertyName("passwordReusePrevention")]
    public double? PasswordReusePrevention { get; set; }

    /// <summary>Whether to require lowercase characters for user passwords.</summary>
    [JsonPropertyName("requireLowercaseCharacters")]
    public bool? RequireLowercaseCharacters { get; set; }

    /// <summary>Whether to require numbers for user passwords.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether to require symbols for user passwords.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether to require uppercase characters for user passwords.</summary>
    [JsonPropertyName("requireUppercaseCharacters")]
    public bool? RequireUppercaseCharacters { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicySpecInitProvider
{
    /// <summary>Whether to allow users to change their own password</summary>
    [JsonPropertyName("allowUsersToChangePassword")]
    public bool? AllowUsersToChangePassword { get; set; }

    /// <summary>Whether users are prevented from setting a new password after their password has expired (i.e., require administrator reset)</summary>
    [JsonPropertyName("hardExpiry")]
    public bool? HardExpiry { get; set; }

    /// <summary>The number of days that an user password is valid.</summary>
    [JsonPropertyName("maxPasswordAge")]
    public double? MaxPasswordAge { get; set; }

    /// <summary>Minimum length to require for user passwords.</summary>
    [JsonPropertyName("minimumPasswordLength")]
    public double? MinimumPasswordLength { get; set; }

    /// <summary>The number of previous passwords that users are prevented from reusing.</summary>
    [JsonPropertyName("passwordReusePrevention")]
    public double? PasswordReusePrevention { get; set; }

    /// <summary>Whether to require lowercase characters for user passwords.</summary>
    [JsonPropertyName("requireLowercaseCharacters")]
    public bool? RequireLowercaseCharacters { get; set; }

    /// <summary>Whether to require numbers for user passwords.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether to require symbols for user passwords.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether to require uppercase characters for user passwords.</summary>
    [JsonPropertyName("requireUppercaseCharacters")]
    public bool? RequireUppercaseCharacters { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicySpecProviderConfigRefPolicy
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
public partial class V1beta1AccountPasswordPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountPasswordPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicySpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1AccountPasswordPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountPasswordPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AccountPasswordPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AccountPasswordPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AccountPasswordPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AccountPasswordPolicySpec defines the desired state of AccountPasswordPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AccountPasswordPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AccountPasswordPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccountPasswordPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AccountPasswordPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccountPasswordPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicyStatusAtProvider
{
    /// <summary>Whether to allow users to change their own password</summary>
    [JsonPropertyName("allowUsersToChangePassword")]
    public bool? AllowUsersToChangePassword { get; set; }

    /// <summary>Indicates whether passwords in the account expire. Returns true if max_password_age contains a value greater than 0. Returns false if it is 0 or not present.</summary>
    [JsonPropertyName("expirePasswords")]
    public bool? ExpirePasswords { get; set; }

    /// <summary>Whether users are prevented from setting a new password after their password has expired (i.e., require administrator reset)</summary>
    [JsonPropertyName("hardExpiry")]
    public bool? HardExpiry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The number of days that an user password is valid.</summary>
    [JsonPropertyName("maxPasswordAge")]
    public double? MaxPasswordAge { get; set; }

    /// <summary>Minimum length to require for user passwords.</summary>
    [JsonPropertyName("minimumPasswordLength")]
    public double? MinimumPasswordLength { get; set; }

    /// <summary>The number of previous passwords that users are prevented from reusing.</summary>
    [JsonPropertyName("passwordReusePrevention")]
    public double? PasswordReusePrevention { get; set; }

    /// <summary>Whether to require lowercase characters for user passwords.</summary>
    [JsonPropertyName("requireLowercaseCharacters")]
    public bool? RequireLowercaseCharacters { get; set; }

    /// <summary>Whether to require numbers for user passwords.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether to require symbols for user passwords.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether to require uppercase characters for user passwords.</summary>
    [JsonPropertyName("requireUppercaseCharacters")]
    public bool? RequireUppercaseCharacters { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicyStatusConditions
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

/// <summary>AccountPasswordPolicyStatus defines the observed state of AccountPasswordPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountPasswordPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AccountPasswordPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccountPasswordPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AccountPasswordPolicy is the Schema for the AccountPasswordPolicys API. Manages Password Policy for the AWS Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccountPasswordPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccountPasswordPolicySpec>, IStatus<V1beta1AccountPasswordPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccountPasswordPolicy";
    public const string KubeGroup = "iam.aws.upbound.io";
    public const string KubePluralName = "accountpasswordpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccountPasswordPolicySpec defines the desired state of AccountPasswordPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1AccountPasswordPolicySpec Spec { get; set; }

    /// <summary>AccountPasswordPolicyStatus defines the observed state of AccountPasswordPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccountPasswordPolicyStatus? Status { get; set; }
}