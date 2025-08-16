using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.administrativeunits.azuread.m.upbound.io;
/// <summary>Unit is the Schema for the Units API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UnitList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Unit>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UnitList";
    public const string KubeGroup = "administrativeunits.azuread.m.upbound.io";
    public const string KubePluralName = "units";
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
    public IList<V1beta1Unit> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UnitSpecForProvider
{
    /// <summary>The description of the administrative unit. The description for the administrative unit</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the administrative unit. The display name for the administrative unit</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether the administrative unit and its members are hidden or publicly viewable in the directory. Whether the administrative unit and its members are hidden or publicly viewable in the directory</summary>
    [JsonPropertyName("hiddenMembershipEnabled")]
    public bool? HiddenMembershipEnabled { get; set; }

    /// <summary>A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups. A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>If `true`, will return an error if an existing administrative unit is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UnitSpecInitProvider
{
    /// <summary>The description of the administrative unit. The description for the administrative unit</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the administrative unit. The display name for the administrative unit</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether the administrative unit and its members are hidden or publicly viewable in the directory. Whether the administrative unit and its members are hidden or publicly viewable in the directory</summary>
    [JsonPropertyName("hiddenMembershipEnabled")]
    public bool? HiddenMembershipEnabled { get; set; }

    /// <summary>A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups. A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>If `true`, will return an error if an existing administrative unit is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UnitSpecProviderConfigRef
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
public partial class V1beta1UnitSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>UnitSpec defines the desired state of Unit</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UnitSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1UnitSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1UnitSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UnitSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UnitSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UnitStatusAtProvider
{
    /// <summary>The description of the administrative unit. The description for the administrative unit</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the administrative unit. The display name for the administrative unit</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether the administrative unit and its members are hidden or publicly viewable in the directory. Whether the administrative unit and its members are hidden or publicly viewable in the directory</summary>
    [JsonPropertyName("hiddenMembershipEnabled")]
    public bool? HiddenMembershipEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups. A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups</summary>
    [JsonPropertyName("members")]
    public IList<string>? Members { get; set; }

    /// <summary>The object ID of the administrative unit. The object ID of the administrative unit</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>If `true`, will return an error if an existing administrative unit is found with the same name</summary>
    [JsonPropertyName("preventDuplicateNames")]
    public bool? PreventDuplicateNames { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UnitStatusConditions
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

/// <summary>UnitStatus defines the observed state of Unit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UnitStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1UnitStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UnitStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Unit is the Schema for the Units API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Unit : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UnitSpec>, IStatus<V1beta1UnitStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Unit";
    public const string KubeGroup = "administrativeunits.azuread.m.upbound.io";
    public const string KubePluralName = "units";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UnitSpec defines the desired state of Unit</summary>
    [JsonPropertyName("spec")]
    public V1beta1UnitSpec Spec { get; set; }

    /// <summary>UnitStatus defines the observed state of Unit.</summary>
    [JsonPropertyName("status")]
    public V1beta1UnitStatus? Status { get; set; }
}