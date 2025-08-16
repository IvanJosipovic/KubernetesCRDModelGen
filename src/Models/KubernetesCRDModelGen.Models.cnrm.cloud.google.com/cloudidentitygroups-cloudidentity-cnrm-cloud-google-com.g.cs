using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudidentity.cnrm.cloud.google.com;
/// <summary>CloudIdentityGroup is the Schema for the CloudIdentityGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudIdentityGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CloudIdentityGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudIdentityGroupList";
    public const string KubeGroup = "cloudidentity.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudidentitygroups";
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
    public IList<V1beta1CloudIdentityGroup> Items { get; set; }
}

/// <summary>Immutable. EntityKey of the Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityGroupSpecGroupKey
{
    /// <summary>Immutable. The ID of the entity. For Google-managed entities, the `id` must be the email address of an existing group or user. For external-identity-mapped entities, the `id` must be a string conforming to the Identity Source's requirements. Must be unique within a `namespace`.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Immutable. The namespace in which the entity exists. If not specified, the `EntityKey` represents a Google-managed entity such as a Google user or a Google Group. If specified, the `EntityKey` represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of `identitysources/{identity_source_id}`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>CloudIdentityGroupSpec defines the desired state of CloudIdentityGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityGroupSpec
{
    /// <summary>An extended description to help users determine the purpose of a `Group`. Must not be longer than 4,096 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The display name of the `Group`.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. EntityKey of the Group.</summary>
    [JsonPropertyName("groupKey")]
    public V1beta1CloudIdentityGroupSpecGroupKey GroupKey { get; set; }

    /// <summary>Immutable. The initial configuration options for creating a Group. See the [API reference](https://cloud.google.com/identity/docs/reference/rest/v1beta1/groups/create#initialgroupconfig) for possible values. Default value: "EMPTY" Possible values: ["INITIAL_GROUP_CONFIG_UNSPECIFIED", "WITH_INITIAL_OWNER", "EMPTY"].</summary>
    [JsonPropertyName("initialGroupConfig")]
    public string? InitialGroupConfig { get; set; }

    /// <summary>One or more label entries that apply to the Group. Currently supported labels contain a key with an empty value. Google Groups are the default type of group and have a label with a key of cloudidentity.googleapis.com/groups.discussion_forum and an empty value. Existing Google Groups can have an additional label with a key of cloudidentity.googleapis.com/groups.security and an empty value added to them. This is an immutable change and the security label cannot be removed once added. Dynamic groups have a label with a key of cloudidentity.googleapis.com/groups.dynamic. Identity-mapped groups for Cloud Search have a label with a key of system/groups/external and an empty value.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string> Labels { get; set; }

    /// <summary>Immutable. The resource name of the entity under which this `Group` resides in the Cloud Identity resource hierarchy. Must be of the form `identitysources/{identity_source}` for external [identity-mapped groups](https://support.google.com/a/answer/9039510) or `customers/{customer_id}` for Google Groups. The `customer_id` must begin with "C" (for example, 'C046psxkn'). [Find your customer ID.] (https://support.google.com/cloudidentity/answer/10070793)</summary>
    [JsonPropertyName("parent")]
    public string Parent { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Format: groups/{groupID} or {groupID}. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityGroupStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityGroupStatusObservedStateAdditionalGroupKeys
{
    /// <summary>Immutable. The ID of the entity. For Google-managed entities, the `id` must be the email address of an existing group or user. For external-identity-mapped entities, the `id` must be a string conforming to the Identity Source's requirements. Must be unique within a `namespace`.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Immutable. The namespace in which the entity exists. If not specified, the `EntityKey` represents a Google-managed entity such as a Google user or a Google Group. If specified, the `EntityKey` represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of `identitysources/{identity_source_id}`.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityGroupStatusObservedState
{
    /// <summary>Additional group keys associated with the Group.</summary>
    [JsonPropertyName("additionalGroupKeys")]
    public IList<V1beta1CloudIdentityGroupStatusObservedStateAdditionalGroupKeys>? AdditionalGroupKeys { get; set; }
}

/// <summary>CloudIdentityGroupStatus defines the config connector machine state of CloudIdentityGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudIdentityGroupStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CloudIdentityGroupStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the `Group` was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A unique Config Connector specifier for the resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Group`. Shall be of the form `groups/{group_id}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1CloudIdentityGroupStatusObservedState? ObservedState { get; set; }

    /// <summary>The time when the `Group` was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CloudIdentityGroup is the Schema for the CloudIdentityGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudIdentityGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CloudIdentityGroupSpec>, IStatus<V1beta1CloudIdentityGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudIdentityGroup";
    public const string KubeGroup = "cloudidentity.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudidentitygroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudIdentityGroupSpec defines the desired state of CloudIdentityGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1CloudIdentityGroupSpec Spec { get; set; }

    /// <summary>CloudIdentityGroupStatus defines the config connector machine state of CloudIdentityGroup</summary>
    [JsonPropertyName("status")]
    public V1beta1CloudIdentityGroupStatus? Status { get; set; }
}