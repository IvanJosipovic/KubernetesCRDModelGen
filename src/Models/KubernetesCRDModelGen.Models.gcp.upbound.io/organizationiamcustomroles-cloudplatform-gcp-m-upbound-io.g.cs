using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudplatform.gcp.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationIAMCustomRoleSpecForProvider
{
    /// <summary>A human-readable description for the role.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The numeric ID of the organization in which you want to create a custom role.</summary>
    [JsonPropertyName("orgId")]
    public string? OrgId { get; set; }

    /// <summary>The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>The role id to use for this role.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>The current launch stage of the role. Defaults to GA. List of possible stages is here.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>A human-readable title for the role.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationIAMCustomRoleSpecInitProvider
{
    /// <summary>A human-readable description for the role.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The numeric ID of the organization in which you want to create a custom role.</summary>
    [JsonPropertyName("orgId")]
    public string? OrgId { get; set; }

    /// <summary>The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>The role id to use for this role.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>The current launch stage of the role. Defaults to GA. List of possible stages is here.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>A human-readable title for the role.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationIAMCustomRoleSpecProviderConfigRef
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
public partial class V1beta1OrganizationIAMCustomRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>OrganizationIAMCustomRoleSpec defines the desired state of OrganizationIAMCustomRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationIAMCustomRoleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OrganizationIAMCustomRoleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OrganizationIAMCustomRoleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OrganizationIAMCustomRoleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OrganizationIAMCustomRoleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationIAMCustomRoleStatusAtProvider
{
    /// <summary>The current deleted state of the role.</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>A human-readable description for the role.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with the format organizations/{{org_id}}/roles/{{role_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the role in the format organizations/{{org_id}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The numeric ID of the organization in which you want to create a custom role.</summary>
    [JsonPropertyName("orgId")]
    public string? OrgId { get; set; }

    /// <summary>The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>The role id to use for this role.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>The current launch stage of the role. Defaults to GA. List of possible stages is here.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>A human-readable title for the role.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationIAMCustomRoleStatusConditions
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

/// <summary>OrganizationIAMCustomRoleStatus defines the observed state of OrganizationIAMCustomRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationIAMCustomRoleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OrganizationIAMCustomRoleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OrganizationIAMCustomRoleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OrganizationIAMCustomRole is the Schema for the OrganizationIAMCustomRoles API. Allows management of a customized Cloud IAM organization role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OrganizationIAMCustomRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OrganizationIAMCustomRoleSpec>, IStatus<V1beta1OrganizationIAMCustomRoleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OrganizationIAMCustomRole";
    public const string KubeGroup = "cloudplatform.gcp.m.upbound.io";
    public const string KubePluralName = "organizationiamcustomroles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrganizationIAMCustomRoleSpec defines the desired state of OrganizationIAMCustomRole</summary>
    [JsonPropertyName("spec")]
    public V1beta1OrganizationIAMCustomRoleSpec Spec { get; set; }

    /// <summary>OrganizationIAMCustomRoleStatus defines the observed state of OrganizationIAMCustomRole.</summary>
    [JsonPropertyName("status")]
    public V1beta1OrganizationIAMCustomRoleStatus? Status { get; set; }
}

/// <summary>OrganizationIAMCustomRole is the Schema for the OrganizationIAMCustomRoles API. Allows management of a customized Cloud IAM organization role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OrganizationIAMCustomRoleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1OrganizationIAMCustomRole>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OrganizationIAMCustomRoleList";
    public const string KubeGroup = "cloudplatform.gcp.m.upbound.io";
    public const string KubePluralName = "organizationiamcustomroles";
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
    public IList<V1beta1OrganizationIAMCustomRole> Items { get; set; }
}