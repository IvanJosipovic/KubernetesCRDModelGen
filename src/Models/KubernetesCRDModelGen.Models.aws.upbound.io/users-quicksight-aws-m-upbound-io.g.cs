using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.quicksight.aws.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProvider
{
    /// <summary>ID for the AWS account that the user is in. Use the ID for the AWS account that contains your Amazon QuickSight account.</summary>
    [JsonPropertyName("awsAccountId")]
    public string? AwsAccountId { get; set; }

    /// <summary>Email address of the user that you want to register.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ARN of the IAM user or role that you are registering with Amazon QuickSight. Required only for users with an identity type of IAM.</summary>
    [JsonPropertyName("iamArn")]
    public string? IamArn { get; set; }

    /// <summary>Identity type that your Amazon QuickSight account uses to manage the identity of users. Valid values: IAM, QUICKSIGHT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>The Amazon Quicksight namespace to create the user in. Defaults to default.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Name of the IAM session to use when assuming roles that can embed QuickSight dashboards. Only valid for registering users using an assumed IAM role. Additionally, if registering multiple users using the same IAM role, each user needs to have a unique session name.</summary>
    [JsonPropertyName("sessionName")]
    public string? SessionName { get; set; }

    /// <summary>Amazon QuickSight user name that you want to create for the user you are registering. Required only for users with an identity type of QUICKSIGHT.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>Amazon QuickSight role for the user. Value values: READER, AUTHOR, ADMIN, READER_PRO, AUTHOR_PRO, ADMIN_PRO.</summary>
    [JsonPropertyName("userRole")]
    public string? UserRole { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProvider
{
    /// <summary>ID for the AWS account that the user is in. Use the ID for the AWS account that contains your Amazon QuickSight account.</summary>
    [JsonPropertyName("awsAccountId")]
    public string? AwsAccountId { get; set; }

    /// <summary>Email address of the user that you want to register.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ARN of the IAM user or role that you are registering with Amazon QuickSight. Required only for users with an identity type of IAM.</summary>
    [JsonPropertyName("iamArn")]
    public string? IamArn { get; set; }

    /// <summary>Identity type that your Amazon QuickSight account uses to manage the identity of users. Valid values: IAM, QUICKSIGHT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>The Amazon Quicksight namespace to create the user in. Defaults to default.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Name of the IAM session to use when assuming roles that can embed QuickSight dashboards. Only valid for registering users using an assumed IAM role. Additionally, if registering multiple users using the same IAM role, each user needs to have a unique session name.</summary>
    [JsonPropertyName("sessionName")]
    public string? SessionName { get; set; }

    /// <summary>Amazon QuickSight user name that you want to create for the user you are registering. Required only for users with an identity type of QUICKSIGHT.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>Amazon QuickSight role for the user. Value values: READER, AUTHOR, ADMIN, READER_PRO, AUTHOR_PRO, ADMIN_PRO.</summary>
    [JsonPropertyName("userRole")]
    public string? UserRole { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecProviderConfigRef
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
public partial class V1beta1UserSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>UserSpec defines the desired state of User</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1UserSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1UserSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UserSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UserSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) for the user.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID for the AWS account that the user is in. Use the ID for the AWS account that contains your Amazon QuickSight account.</summary>
    [JsonPropertyName("awsAccountId")]
    public string? AwsAccountId { get; set; }

    /// <summary>Email address of the user that you want to register.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ARN of the IAM user or role that you are registering with Amazon QuickSight. Required only for users with an identity type of IAM.</summary>
    [JsonPropertyName("iamArn")]
    public string? IamArn { get; set; }

    /// <summary>Unique identifier consisting of the account ID, the namespace, and the user name separated by /s.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity type that your Amazon QuickSight account uses to manage the identity of users. Valid values: IAM, QUICKSIGHT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>The Amazon Quicksight namespace to create the user in. Defaults to default.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Name of the IAM session to use when assuming roles that can embed QuickSight dashboards. Only valid for registering users using an assumed IAM role. Additionally, if registering multiple users using the same IAM role, each user needs to have a unique session name.</summary>
    [JsonPropertyName("sessionName")]
    public string? SessionName { get; set; }

    /// <summary>URL the user visits to complete registration and provide a password. Returned only for users with an identity type of QUICKSIGHT.</summary>
    [JsonPropertyName("userInvitationUrl")]
    public string? UserInvitationUrl { get; set; }

    /// <summary>Amazon QuickSight user name that you want to create for the user you are registering. Required only for users with an identity type of QUICKSIGHT.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>Amazon QuickSight role for the user. Value values: READER, AUTHOR, ADMIN, READER_PRO, AUTHOR_PRO, ADMIN_PRO.</summary>
    [JsonPropertyName("userRole")]
    public string? UserRole { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusConditions
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

/// <summary>UserStatus defines the observed state of User.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1UserStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UserStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>User is the Schema for the Users API. Manages a Resource QuickSight User.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1User : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UserSpec>, IStatus<V1beta1UserStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "User";
    public const string KubeGroup = "quicksight.aws.m.upbound.io";
    public const string KubePluralName = "users";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserSpec defines the desired state of User</summary>
    [JsonPropertyName("spec")]
    public V1beta1UserSpec Spec { get; set; }

    /// <summary>UserStatus defines the observed state of User.</summary>
    [JsonPropertyName("status")]
    public V1beta1UserStatus? Status { get; set; }
}

/// <summary>User is the Schema for the Users API. Manages a Resource QuickSight User.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserList : IKubernetesObject<V1ListMeta>, IItems<V1beta1User>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserList";
    public const string KubeGroup = "quicksight.aws.m.upbound.io";
    public const string KubePluralName = "users";
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
    public IList<V1beta1User> Items { get; set; }
}