using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.directoryroles.azuread.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleSpecForProviderPermissions
{
    /// <summary>A set of tasks that can be performed on a resource. For more information, see the Permissions Reference documentation. Set of tasks that can be performed on a resource</summary>
    [JsonPropertyName("allowedResourceActions")]
    public IList<string>? AllowedResourceActions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleSpecForProvider
{
    /// <summary>The description of the custom directory role. The description of the custom directory role</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the custom directory role. The display name of the custom directory role</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates whether the role is enabled for assignment. Indicates whether the role is enabled for assignment</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A collection of permissions blocks as documented below. List of permissions that are included in the custom directory role</summary>
    [JsonPropertyName("permissions")]
    public IList<V1beta1CustomDirectoryRoleSpecForProviderPermissions>? Permissions { get; set; }

    /// <summary>Custom template identifier that is typically used if one needs an identifier to be the same across different directories. Changing this forces a new resource to be created. Custom template identifier that is typically used if one needs an identifier to be the same across different directories.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>- The version of the role definition. This can be any arbitrary string between 1-128 characters. The version of the role definition.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleSpecInitProviderPermissions
{
    /// <summary>A set of tasks that can be performed on a resource. For more information, see the Permissions Reference documentation. Set of tasks that can be performed on a resource</summary>
    [JsonPropertyName("allowedResourceActions")]
    public IList<string>? AllowedResourceActions { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleSpecInitProvider
{
    /// <summary>The description of the custom directory role. The description of the custom directory role</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the custom directory role. The display name of the custom directory role</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates whether the role is enabled for assignment. Indicates whether the role is enabled for assignment</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A collection of permissions blocks as documented below. List of permissions that are included in the custom directory role</summary>
    [JsonPropertyName("permissions")]
    public IList<V1beta1CustomDirectoryRoleSpecInitProviderPermissions>? Permissions { get; set; }

    /// <summary>Custom template identifier that is typically used if one needs an identifier to be the same across different directories. Changing this forces a new resource to be created. Custom template identifier that is typically used if one needs an identifier to be the same across different directories.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>- The version of the role definition. This can be any arbitrary string between 1-128 characters. The version of the role definition.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleSpecProviderConfigRefPolicy
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
public partial class V1beta1CustomDirectoryRoleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDirectoryRoleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CustomDirectoryRoleSpec defines the desired state of CustomDirectoryRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CustomDirectoryRoleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CustomDirectoryRoleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CustomDirectoryRoleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CustomDirectoryRoleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleStatusAtProviderPermissions
{
    /// <summary>A set of tasks that can be performed on a resource. For more information, see the Permissions Reference documentation. Set of tasks that can be performed on a resource</summary>
    [JsonPropertyName("allowedResourceActions")]
    public IList<string>? AllowedResourceActions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleStatusAtProvider
{
    /// <summary>The description of the custom directory role. The description of the custom directory role</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the custom directory role. The display name of the custom directory role</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates whether the role is enabled for assignment. Indicates whether the role is enabled for assignment</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The object ID of the custom directory role. The object ID of the directory role</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>A collection of permissions blocks as documented below. List of permissions that are included in the custom directory role</summary>
    [JsonPropertyName("permissions")]
    public IList<V1beta1CustomDirectoryRoleStatusAtProviderPermissions>? Permissions { get; set; }

    /// <summary>Custom template identifier that is typically used if one needs an identifier to be the same across different directories. Changing this forces a new resource to be created. Custom template identifier that is typically used if one needs an identifier to be the same across different directories.</summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>- The version of the role definition. This can be any arbitrary string between 1-128 characters. The version of the role definition.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleStatusConditions
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

/// <summary>CustomDirectoryRoleStatus defines the observed state of CustomDirectoryRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDirectoryRoleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CustomDirectoryRoleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CustomDirectoryRoleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CustomDirectoryRole is the Schema for the CustomDirectoryRoles API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomDirectoryRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CustomDirectoryRoleSpec>, IStatus<V1beta1CustomDirectoryRoleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomDirectoryRole";
    public const string KubeGroup = "directoryroles.azuread.upbound.io";
    public const string KubePluralName = "customdirectoryroles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomDirectoryRoleSpec defines the desired state of CustomDirectoryRole</summary>
    [JsonPropertyName("spec")]
    public V1beta1CustomDirectoryRoleSpec Spec { get; set; }

    /// <summary>CustomDirectoryRoleStatus defines the observed state of CustomDirectoryRole.</summary>
    [JsonPropertyName("status")]
    public V1beta1CustomDirectoryRoleStatus? Status { get; set; }
}

/// <summary>CustomDirectoryRole is the Schema for the CustomDirectoryRoles API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomDirectoryRoleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CustomDirectoryRole>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomDirectoryRoleList";
    public const string KubeGroup = "directoryroles.azuread.upbound.io";
    public const string KubePluralName = "customdirectoryroles";
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
    public IList<V1beta1CustomDirectoryRole> Items { get; set; }
}